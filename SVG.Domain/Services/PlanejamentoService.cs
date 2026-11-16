using System.ComponentModel.DataAnnotations;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Planejamento;

namespace SVG.Domain.Services;

public class PlanejamentoService(IPlanejamentoRepository repository) : IPlanejamentoService
{
    public Planejamento? Obter(int id) => repository.Obter(id);
    public Alvo? ObterAlvo(int id) => repository.ObterAlvo(id);
    public AnexoAlvo? ObterFoto(int id) => repository.ObterFoto(id);
    public AnexoAlvo? ObterAnexoAlvo(int id) => repository.ObterAnexoAlvo(id);
    public AnexoPlanejamento? ObterAnexo(int id) => repository.ObterAnexo(id);
    public IReadOnlyList<XPlanejamentoResumo> Listar(int? secaoId) => repository.Listar(secaoId);
    public IReadOnlyList<XAlvoResumo> BuscarAlvos(string termo)
    {
        termo = (termo ?? "").Trim();
        return termo.Length < 2 ? Array.Empty<XAlvoResumo>() : repository.BuscarAlvos(termo[..Math.Min(200, termo.Length)]);
    }
    public int Salvar(XPlanejamentoEntrada e, XAutorPlanejamento autor, IReadOnlyList<XAnexoAlvoEntrada> fotos, bool finalizar, IReadOnlyList<XArquivoPlanejamentoEntrada>? anexos=null)
    {
        Validar(e, autor, fotos, finalizar);
        anexos ??= Array.Empty<XArquivoPlanejamentoEntrada>();
        if(anexos.Count>20 || anexos.Sum(a=>(long)a.Conteudo.Length)+fotos.Sum(f=>(long)f.Conteudo.Length)>100*1024*1024)
            throw new ValidationException("Limite de 20 anexos e 100 MB por gravação.");
        foreach(var a in anexos)
        {
            if(!a.Subgrupo.HasValue || !Enum.IsDefined(a.Subgrupo.Value))
                throw new ValidationException("Selecione um subgrupo válido para cada imagem do planejamento.");
            if(a.Conteudo.Length>50*1024*1024 || TipoArquivo(a.Conteudo)==null) throw new ValidationException("Anexos devem ser PNG, JPEG, MP4 ou WebM, com até 50 MB cada.");
        }
        return repository.Salvar(e, autor, fotos, finalizar, anexos);
    }
    public static void Validar(XPlanejamentoEntrada e, XAutorPlanejamento autor, IReadOnlyList<XAnexoAlvoEntrada> fotos, bool finalizar)
    {
        if (autor.OperadorID <= 0) throw new ValidationException("É necessário um operador vinculado ao usuário para gravar.");
        Validator.ValidateObject(e, new ValidationContext(e), true);
        if (e.ID < 0 || e.ID > 0 && string.IsNullOrWhiteSpace(e.Versao)) throw new ValidationException("Versão do planejamento não informada.");
        if (e.Latitude.HasValue != e.Longitude.HasValue) throw new ValidationException("Informe latitude e longitude juntas.");
        if (e.Alvos == null || e.Itens == null || e.Integrantes == null || e.Alvos.Count > 50 || e.Itens.Count > 150 || e.Integrantes.Count > 100)
            throw new ValidationException("Quantidade de registros inválida.");
        if (finalizar && (e.Alvos.Count == 0 || string.IsNullOrWhiteSpace(e.Endereco) || !e.DataPrevista.HasValue))
            throw new ValidationException("Para finalizar, informe data, endereço e pelo menos um alvo.");
        foreach(var link in new[]{e.Link_Rota_DOE_Unidade_Apoio,e.Link_Rota_DP_Desemb,e.Link_Localizacao_Desemb,e.Link_Localizacao_Hospital_1,e.Link_Localizacao_Hospital_2})
            if(!string.IsNullOrWhiteSpace(link) && (!Uri.TryCreate(link,UriKind.Absolute,out var uri) || uri.Scheme!="https" || uri.UserInfo.Length>0))
                throw new ValidationException("Links de rotas e localizações devem ser endereços HTTPS válidos.");
        foreach(var horario in new[]{e.HorarioBriefingDOE,e.HorarioSaidaDOE,e.HorarioBriefingDP})
            if(horario.HasValue && (horario.Value<TimeSpan.Zero || horario.Value>=TimeSpan.FromDays(1)))
                throw new ValidationException("Informe horários entre 00:00 e 23:59.");
        foreach (var a in e.Alvos)
        {
            Validator.ValidateObject(a, new ValidationContext(a), true);
            if (a.AlvoID is <= 0) throw new ValidationException("Alvo existente inválido.");
            if (!a.AlvoID.HasValue && string.IsNullOrWhiteSpace(a.Nome)) throw new ValidationException("Informe o nome ou a identificação provisória de cada novo alvo.");
            a.CPF = NormalizarCpf(a.CPF);
            if (a.CPF != null && !CpfValido(a.CPF)) throw new ValidationException("CPF inválido. Corrija ou deixe em branco quando desconhecido.");
            if (a.DataNascimento > DateTime.Today) throw new ValidationException("Data de nascimento futura.");
        }
        if (e.Alvos.Where(a=>a.AlvoID.HasValue).GroupBy(a=>a.AlvoID).Any(g=>g.Count()>1)
            || e.Alvos.Where(a=>a.CPF!=null).GroupBy(a=>a.CPF).Any(g=>g.Count()>1))
            throw new ValidationException("O mesmo alvo não pode ser vinculado duas vezes.");
        if (e.Alvos.Where(a=>!string.IsNullOrWhiteSpace(a.Codigo)).GroupBy(a=>a.Codigo!.Trim(),StringComparer.OrdinalIgnoreCase).Any(g=>g.Count()>1))
            throw new ValidationException("Código de alvo repetido no planejamento.");
        foreach (var i in e.Itens)
        {
            Validator.ValidateObject(i, new ValidationContext(i), true);
            if (!new[]{"Horario","Rota","Localizacao","Mandado","Providencia"}.Contains(i.Tipo)) throw new ValidationException("Tipo de informação inválido.");
            if (!string.IsNullOrWhiteSpace(i.Url) && (!Uri.TryCreate(i.Url, UriKind.Absolute, out var uri) || uri.Scheme != "https"))
                throw new ValidationException("Links devem ser endereços HTTPS válidos.");
        }
        foreach (var i in e.Integrantes) Validator.ValidateObject(i, new ValidationContext(i), true);
        if(e.Integrantes.GroupBy(i=>i.OperadorID).Any(g=>g.Count()>1)) throw new ValidationException("Operador repetido na equipe.");
        if(fotos.Count>50 || fotos.Sum(f=>(long)f.Conteudo.Length)>100*1024*1024
            || fotos.Where(f=>f.FotoPrincipal).GroupBy(f=>f.IndiceAlvo).Any(g=>g.Count()>1))
            throw new ValidationException("Envie até 50 anexos de alvos e uma foto principal por alvo, até 100 MB no total.");
        foreach (var foto in fotos)
        {
            if (foto.IndiceAlvo<0 || foto.IndiceAlvo>=e.Alvos.Count)
                throw new ValidationException("O anexo deve pertencer a um alvo deste planejamento.");
            if(foto.Conteudo.Length>50*1024*1024 || TipoArquivo(foto.Conteudo)==null)
                throw new ValidationException("Anexos devem ser PNG, JPEG, MP4 ou WebM, com até 50 MB cada.");
            if(foto.FotoPrincipal && (foto.Conteudo.Length>5*1024*1024 || TipoFoto(foto.Conteudo)==null))
                throw new ValidationException("A foto principal deve ser PNG ou JPEG, com até 5 MB.");
        }
    }
    public static string? NormalizarCpf(string? valor) => string.IsNullOrWhiteSpace(valor) ? null : valor.Replace(".","").Replace("-","").Trim();
    public static bool CpfValido(string cpf)
    {
        if(cpf.Length!=11 || cpf.Any(c=>c<'0'||c>'9') || cpf.Distinct().Count()==1) return false;
        for(int tamanho=9;tamanho<=10;tamanho++)
        {
            int soma=0;
            for(int i=0;i<tamanho;i++) soma+=(cpf[i]-'0')*(tamanho+1-i);
            int digito=(soma*10)%11; if(digito==10) digito=0;
            if(cpf[tamanho]-'0'!=digito) return false;
        }
        return true;
    }
    public static string? TipoFoto(byte[] b) => b.Length>=8 && b.Take(8).SequenceEqual(new byte[]{137,80,78,71,13,10,26,10}) ? "image/png"
        : b.Length>=4 && b[0]==255 && b[1]==216 && b[2]==255 && b[^2]==255 && b[^1]==217 ? "image/jpeg" : null;
    public static string? TipoArquivo(byte[] b)
    {
        var foto=TipoFoto(b); if(foto!=null)return foto;
        // MP4: caixa ftyp e marca de formato; WebM: cabeçalho EBML e DocType webm.
        if(b.Length>=24 && System.Text.Encoding.ASCII.GetString(b,4,4)=="ftyp"
            && new[]{"isom","iso2","mp41","mp42","avc1","M4V "}.Contains(System.Text.Encoding.ASCII.GetString(b,8,4))) return "video/mp4";
        if(b.Length>=12 && b[0]==0x1A && b[1]==0x45 && b[2]==0xDF && b[3]==0xA3
            && b.AsSpan(4,Math.Min(b.Length-4,4096)).IndexOf(new byte[]{0x42,0x82,0x84,0x77,0x65,0x62,0x6D})>=0) return "video/webm";
        return null;
    }
}
