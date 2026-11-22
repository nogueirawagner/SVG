using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Services;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Planejamento;
using SVG.Infra.Context.SQLServer;

namespace SVG.Infra.Repositories;

public class PlanejamentoRepository(SQLServerContext db, IArmazenamentoAnexos armazenamento) : IPlanejamentoRepository
{
    public Planejamento? Obter(int id)
    {
        var p = db.Planejamento.AsNoTracking().Include(p=>p.Secao)
        .Include(p=>p.Alvos.Select(a=>a.Alvo)).Include(p=>p.Itens)
        .Include(p=>p.Integrantes.Select(i=>i.Operador)).Include(p=>p.Integrantes.Select(i=>i.Viatura)).SingleOrDefault(p=>p.ID==id);
        if(p!=null) p.Anexos=db.AnexoPlanejamento.AsNoTracking().Where(a=>a.PlanejamentoID==id)
            .Select(a=>new {a.ID,a.NomeArquivo,a.TipoMime,a.DataHoraCriacao,a.Subgrupo,a.Ordem,a.Caminho}).ToList()
            .Select(a=>new AnexoPlanejamento{ID=a.ID,PlanejamentoID=id,NomeArquivo=a.NomeArquivo,TipoMime=a.TipoMime,DataHoraCriacao=a.DataHoraCriacao,Subgrupo=a.Subgrupo,Ordem=a.Ordem,Caminho=a.Caminho}).ToList();
        return p;
    }
    public AnexoAlvo? ObterAnexoAlvo(int id) => db.AnexoAlvo.AsNoTracking().SingleOrDefault(a=>a.ID==id);
    public AnexoPlanejamento? ObterAnexo(int id) => db.AnexoPlanejamento.AsNoTracking().SingleOrDefault(a=>a.ID==id);
    public Alvo? ObterAlvo(int id) => db.Alvo.AsNoTracking().Include(a=>a.Informacoes).Include(a=>a.Anexos)
        .Include(a=>a.Planejamentos.Select(p=>p.Planejamento.Secao)).SingleOrDefault(a=>a.ID==id);
    public AnexoAlvo? ObterFoto(int id) => db.AnexoAlvo.AsNoTracking().FirstOrDefault(a=>a.AlvoID==id && a.FotoPrincipal);
    public IReadOnlyList<XAlvoResumo> BuscarAlvos(string termo)
    {
        termo=(termo??string.Empty).Trim();
        if(termo.Length<2) return Array.Empty<XAlvoResumo>();
        termo=termo[..Math.Min(200,termo.Length)];
        var cpf=PlanejamentoService.NormalizarCpf(termo);
        // CI_AI ignora caixa e acentos independentemente da collation do banco.
        // CHARINDEX trata o termo como texto literal, inclusive %, _ e [.
        // Filtra e limita no servidor antes de carregar os resumos e suas contagens.
        var ids=db.Database.SqlQuery<int>(@"SELECT TOP (50) a.ID
            FROM dbo.Alvo AS a
            WHERE CHARINDEX(@termo, a.Nome COLLATE Latin1_General_100_CI_AI)>0
               OR CHARINDEX(@termo, a.Alcunha COLLATE Latin1_General_100_CI_AI)>0
               OR (@cpf<>N'' AND a.CPF=@cpf)
            ORDER BY a.Nome, a.ID",
            new SqlParameter("@termo",SqlDbType.NVarChar,200){Value=termo},
            new SqlParameter("@cpf",SqlDbType.NVarChar,200){Value=cpf}).ToList();
        if(ids.Count==0) return Array.Empty<XAlvoResumo>();
        return db.Alvo.AsNoTracking().Where(a=>ids.Contains(a.ID))
            .OrderBy(a=>a.Nome).ThenBy(a=>a.ID).Take(50)
            .Select(a=>new{a.ID,a.Nome,a.Alcunha,a.CPF,Quantidade=a.Planejamentos.Count})
            .ToList().Select(a=>new XAlvoResumo(a.ID,a.Nome,a.Alcunha,a.CPF,a.Quantidade)).ToList();
    }
    public IReadOnlyList<XPlanejamentoMapa> ListarMapa() => db.Planejamento.AsNoTracking()
        .Where(p=>p.Latitude.HasValue && p.Longitude.HasValue && p.Latitude>=-90 && p.Latitude<=90 && p.Longitude>=-180 && p.Longitude<=180)
        .OrderByDescending(p=>p.ID).Take(100)
        .Select(p=>new {p.ID,p.DataPrevista,p.UnidadeApoio,p.SecaoID,Secao=p.Secao.Nome,p.Endereco,p.Latitude,p.Longitude})
        .ToList().Select(p=>new XPlanejamentoMapa(p.ID,Planejamento.FormatarTitulo(p.DataPrevista,p.UnidadeApoio,p.Secao),
            p.DataPrevista?.Year,p.DataPrevista?.Month,p.SecaoID,p.Secao,p.Endereco,p.Latitude!.Value,p.Longitude!.Value)).ToList();

    public IReadOnlyList<XPlanejamentoResumo> Listar(int? secaoId) => db.Planejamento.AsNoTracking()
        .Where(p=>!secaoId.HasValue || p.SecaoID==secaoId.Value).OrderByDescending(p=>p.ID).Take(100)
        .Select(p=>new{p.ID,p.UnidadeApoio,p.DataPrevista,p.Situacao,Secao=p.Secao.Nome,p.Endereco,Quantidade=p.Alvos.Count,p.CriadorOperadorID,p.Versao})
        .ToList().Select(p=>new XPlanejamentoResumo(p.ID,Planejamento.FormatarTitulo(p.DataPrevista,p.UnidadeApoio,p.Secao),p.DataPrevista,p.Situacao,p.Secao,p.Endereco,p.Quantidade,p.CriadorOperadorID,Convert.ToBase64String(p.Versao))).ToList();

    public void Excluir(int id,string versao,XAutorPlanejamento autor)
    {
        using var transaction=db.Database.BeginTransaction(IsolationLevel.Serializable);
        var p=db.Planejamento.SingleOrDefault(x=>x.ID==id) ?? throw new KeyNotFoundException("Planejamento não encontrado.");
        if(autor.OperadorID<=0 || (!autor.Administrador && p.CriadorOperadorID!=autor.OperadorID))
            throw new UnauthorizedAccessException("Somente o autor ou administrador pode excluir.");
        byte[] esperada;
        try { esperada=Convert.FromBase64String(versao); }
        catch(FormatException){throw new ValidationException("Versão inválida. Atualize a listagem.");}
        if(!p.Versao.SequenceEqual(esperada))throw new ValidationException("O planejamento foi alterado. Atualize a listagem antes de excluir.");
        var anexos=db.AnexoPlanejamento.Where(a=>a.PlanejamentoID==id).ToList();
        var caminhos=anexos.Select(a=>a.Caminho).Distinct().ToList();
        // Remove somente dependências do planejamento, nunca os cadastros compartilhados.
        db.PlanejamentoAlvo.RemoveRange(db.PlanejamentoAlvo.Where(a=>a.PlanejamentoID==id));
        db.PlanejamentoItem.RemoveRange(db.PlanejamentoItem.Where(a=>a.PlanejamentoID==id));
        db.PlanejamentoIntegrante.RemoveRange(db.PlanejamentoIntegrante.Where(a=>a.PlanejamentoID==id));
        db.AnexoPlanejamento.RemoveRange(anexos);
        db.Planejamento.Remove(p);
        db.SaveChanges();transaction.Commit();
        // Não há transação distribuída com o armazenamento: falhas ficam registradas para limpeza.
        foreach(var caminho in caminhos)
            try { armazenamento.Excluir(caminho); }
            catch(Exception ex){System.Diagnostics.Trace.TraceError("Falha ao limpar anexo do planejamento excluído {0}: {1}. {2}",id,caminho,ex.Message);}
    }

    public int Salvar(XPlanejamentoEntrada e, XAutorPlanejamento autor, IReadOnlyList<XAnexoAlvoEntrada> fotos, bool finalizar, IReadOnlyList<XArquivoPlanejamentoEntrada>? anexos=null)
    {
        // A transação abrange todos os SaveChanges; não usa Add/Update do RepositoryBase.
        using var transaction=db.Database.BeginTransaction(IsolationLevel.Serializable);
        var gravados=new List<string>();
        string Gravar(string categoria,int id,byte[] conteudo,string mime)
        { var caminho=armazenamento.Gravar(categoria,id,conteudo,mime); gravados.Add(caminho); return caminho; }
        void LimparArquivos()
        {
            // Uma falha na limpeza não deve esconder a falha original da transação.
            foreach(var caminho in gravados)
                try { armazenamento.Excluir(caminho); }
                catch(Exception ex) { System.Diagnostics.Trace.TraceError("Falha na limpeza de anexo {0}: {1}",caminho,ex.Message); }
        }
        try
        {
            var operador=db.Operador.SingleOrDefault(o=>o.ID==autor.OperadorID)
                ?? throw new ValidationException("Operador autenticado não encontrado.");
            if (!db.Sessao.Any(s=>s.ID==operador.SessaoID)) throw new ValidationException("Operador sem seção válida.");
            Planejamento p;
            if(e.ID==0)
            {
                p=new Planejamento{SecaoID=operador.SessaoID,CriadorOperadorID=operador.ID,DataHoraCriacao=DateTime.Now};
                db.Planejamento.Add(p);
            }
            else
            {
                p=db.Planejamento.Include(x=>x.Alvos).Include(x=>x.Itens).Include(x=>x.Integrantes).SingleOrDefault(x=>x.ID==e.ID)
                    ?? throw new KeyNotFoundException("Planejamento não encontrado.");
                if(!autor.Administrador && p.CriadorOperadorID!=autor.OperadorID) throw new UnauthorizedAccessException("Somente o autor ou administrador pode editar.");
                if(p.Situacao!="Rascunho") throw new ValidationException("Planejamento finalizado é somente leitura.");
                byte[] versao;
                try { versao=Convert.FromBase64String(e.Versao??""); } catch(FormatException) { throw new ValidationException("Versão inválida. Reabra o planejamento."); }
                if(!p.Versao.SequenceEqual(versao)) throw new ValidationException("Planejamento alterado por outra pessoa. Reabra antes de salvar.");
                db.Entry(p).Property(x=>x.Versao).OriginalValue=versao;
            }
            // Título e objetivo deixaram de ser campos do formulário; preserva dados existentes.
            if(!string.IsNullOrWhiteSpace(e.Titulo)) p.Titulo=e.Titulo.Trim();
            else if(e.ID==0) p.Titulo=string.IsNullOrWhiteSpace(e.OrdemServico)?"Planejamento":$"Planejamento — OS {e.OrdemServico.Trim()}";
            p.LocalBriefing=Limpar(e.LocalBriefing);
            p.HorarioBriefingDOE=e.HorarioBriefingDOE;
            p.HorarioSaidaDOE=e.HorarioSaidaDOE;
            p.HorarioBriefingDP=e.HorarioBriefingDP;
            p.SocorristaAPH1=Limpar(e.SocorristaAPH1);
            p.SocorristaAPH2=Limpar(e.SocorristaAPH2);
            p.MotoristaVtrAPH=Limpar(e.MotoristaVtrAPH);
            p.PrefixoVtrAPH=Limpar(e.PrefixoVtrAPH);
            p.ResponsavelRelatorio=Limpar(e.ResponsavelRelatorio);
            p.ResponsavelFotoMBA=Limpar(e.ResponsavelFotoMBA);
            p.CoordenadaZPH=Limpar(e.CoordenadaZPH);
            p.Link_Rota_DOE_Unidade_Apoio=Limpar(e.Link_Rota_DOE_Unidade_Apoio);
            p.Link_Rota_DP_Desemb=Limpar(e.Link_Rota_DP_Desemb);
            p.Link_Localizacao_Desemb=Limpar(e.Link_Localizacao_Desemb);
            p.Link_Localizacao_Hospital_1=Limpar(e.Link_Localizacao_Hospital_1);
            p.Link_Localizacao_Hospital_2=Limpar(e.Link_Localizacao_Hospital_2);
            p.DistanciaRotaDOEUnidadeApoioKm=e.DistanciaRotaDOEUnidadeApoioKm;
            p.DuracaoRotaDOEUnidadeApoioMinutos=e.DuracaoRotaDOEUnidadeApoioMinutos;
            p.DistanciaRotaDPDesembKm=e.DistanciaRotaDPDesembKm;
            p.DuracaoRotaDPDesembMinutos=e.DuracaoRotaDPDesembMinutos;
            p.MBA=e.MBA; p.MP=e.MP; p.NumeroMBA=Limpar(e.NumeroMBA); p.DataPrevista=e.DataPrevista; p.OrdemServico=Limpar(e.OrdemServico);
            p.UnidadeApoio=Limpar(e.UnidadeApoio); if(e.Objetivo!=null) p.Objetivo=Limpar(e.Objetivo); p.Endereco=Limpar(e.Endereco);
            p.Referencia=Limpar(e.Referencia); p.Link_Endereco_Alvo=Limpar(e.Link_Endereco_Alvo); p.Latitude=e.Latitude; p.Longitude=e.Longitude;
            p.CanalViaturas=Limpar(e.CanalViaturas); p.CanalOperadores=Limpar(e.CanalOperadores);
            p.ApoioMedico=Limpar(e.ApoioMedico); p.Particularidades=Limpar(e.Particularidades);
            p.DataHoraAtualizacao=DateTime.Now; p.AtualizadoPorOperadorID=autor.OperadorID;
            p.Situacao=finalizar?"Finalizado":"Rascunho";
            // Alvos já vinculados não são removidos: preserva contexto e evita cadastros órfãos.
            if(p.Alvos.Any(v=>!e.Alvos.Any(a=>a.AlvoID==v.AlvoID))) throw new ValidationException("Não é possível remover um alvo já salvo nesta versão.");
            db.SaveChanges(); // Primeiro o planejamento, ainda sem commit.
            var ids=new HashSet<int>();
            for(int index=0;index<e.Alvos.Count;index++)
            {
                var entrada=e.Alvos[index];
                Alvo alvo;
                if(entrada.AlvoID.HasValue)
                    alvo=db.Alvo.Find(entrada.AlvoID.Value) ?? throw new ValidationException("Alvo selecionado não encontrado.");
                else
                {
                    if(entrada.CPF!=null && db.Alvo.Any(a=>a.CPF==entrada.CPF)) throw new ValidationException("CPF já cadastrado. Pesquise e vincule o alvo existente.");
                    alvo=new Alvo{Nome=entrada.Nome!.Trim(),Alcunha=Limpar(entrada.Alcunha),CPF=entrada.CPF,RG=Limpar(entrada.RG),
                        DataNascimento=entrada.DataNascimento,NomeMae=Limpar(entrada.NomeMae),NomePai=Limpar(entrada.NomePai),DataHoraCriacao=DateTime.Now};
                    db.Alvo.Add(alvo);
                    if(!string.IsNullOrWhiteSpace(entrada.Informacoes)) alvo.Informacoes.Add(new InformacaoAlvo{Texto=entrada.Informacoes.Trim(),Fonte=Limpar(entrada.Fonte),DataHoraCriacao=DateTime.Now});
                    db.SaveChanges();
                }
                foreach(var arquivo in fotos.Where(f=>f.IndiceAlvo==index))
                {
                    if(arquivo.FotoPrincipal && db.AnexoAlvo.Any(a=>a.AlvoID==alvo.ID && a.FotoPrincipal))
                        throw new ValidationException("O alvo já possui foto principal.");
                    var mime=PlanejamentoService.TipoArquivo(arquivo.Conteudo)!;
                    var nome=Path.GetFileName(arquivo.NomeArquivo);
                    alvo.Anexos.Add(new AnexoAlvo{NomeArquivo=nome[..Math.Min(255,nome.Length)],TipoMime=mime,
                        Caminho=Gravar("Alvo",alvo.ID,arquivo.Conteudo,mime),FotoPrincipal=arquivo.FotoPrincipal,DataHoraCriacao=DateTime.Now});
                }
                if(!ids.Add(alvo.ID)) throw new ValidationException("Alvo repetido no planejamento.");
                var vinculo=p.Alvos.SingleOrDefault(v=>v.AlvoID==alvo.ID);
                if(vinculo==null) { vinculo=new PlanejamentoAlvo{PlanejamentoID=p.ID,AlvoID=alvo.ID}; p.Alvos.Add(vinculo); }
                // O código saiu do formulário: sua ausência não deve apagar valores anteriores.
                if(entrada.Codigo!=null) vinculo.Codigo=Limpar(entrada.Codigo);
                vinculo.Observacoes=Limpar(entrada.Observacoes);
            }
            db.PlanejamentoItem.RemoveRange(p.Itens.ToList());
            db.PlanejamentoIntegrante.RemoveRange(p.Integrantes.ToList());
            db.SaveChanges(); // Remove linhas antigas antes dos índices únicos das novas.
            foreach(var i in e.Itens) db.PlanejamentoItem.Add(new PlanejamentoItem{PlanejamentoID=p.ID,Tipo=i.Tipo,Descricao=i.Descricao.Trim(),DataHora=i.DataHora,
                Responsavel=Limpar(i.Responsavel),Url=Limpar(i.Url),DistanciaKm=i.DistanciaKm,DuracaoMinutos=i.DuracaoMinutos});
            foreach(var i in e.Integrantes)
            {
                if(!db.Operador.Any(o=>o.ID==i.OperadorID) || i.ViaturaID.HasValue && !db.Viatura.Any(v=>v.ID==i.ViaturaID.Value)) throw new ValidationException("Operador ou viatura não encontrado.");
                db.PlanejamentoIntegrante.Add(new PlanejamentoIntegrante{PlanejamentoID=p.ID,OperadorID=i.OperadorID,ViaturaID=i.ViaturaID,Funcao=i.Funcao.Trim(),Entrada=Limpar(i.Entrada)});
            }
            var ordens=db.AnexoPlanejamento.Where(a=>a.PlanejamentoID==p.ID && a.Subgrupo.HasValue)
                .GroupBy(a=>a.Subgrupo).Select(g=>new {Subgrupo=g.Key,Ordem=g.Max(a=>a.Ordem)})
                .ToList().ToDictionary(g=>g.Subgrupo!.Value,g=>g.Ordem);
            foreach(var a in anexos??Array.Empty<XArquivoPlanejamentoEntrada>())
            {
                var nome=Path.GetFileName(a.NomeArquivo);
                var grupo=a.Subgrupo!.Value;
                var ordem=checked(ordens.GetValueOrDefault(grupo)+1);
                ordens[grupo]=ordem;
                db.AnexoPlanejamento.Add(new AnexoPlanejamento{PlanejamentoID=p.ID,Subgrupo=grupo,Ordem=ordem,NomeArquivo=nome[..Math.Min(255,nome.Length)],TipoMime=PlanejamentoService.TipoArquivo(a.Conteudo)!,Caminho=Gravar("Planejamento",p.ID,a.Conteudo,PlanejamentoService.TipoArquivo(a.Conteudo)!),DataHoraCriacao=DateTime.Now});
            }
            db.SaveChanges(); transaction.Commit(); return p.ID;
        }
        catch(DbUpdateConcurrencyException) { transaction.Rollback(); LimparArquivos(); throw new ValidationException("Planejamento alterado por outra pessoa. Reabra antes de salvar."); }
        catch { transaction.Rollback(); LimparArquivos(); throw; }
    }
    private static string? Limpar(string? s) => string.IsNullOrWhiteSpace(s)?null:s.Trim();
}
