using SVG.App.Interfaces;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Planejamento;
namespace SVG.App.Services;
public class PlanejamentoAppService(IPlanejamentoService service) : IPlanejamentoAppService
{
    public Planejamento? Obter(int id)=>service.Obter(id);
    public Alvo? ObterAlvo(int id)=>service.ObterAlvo(id);
    public AnexoAlvo? ObterFoto(int id)=>service.ObterFoto(id);
    public AnexoAlvo? ObterAnexoAlvo(int id) => service.ObterAnexoAlvo(id);
    public AnexoPlanejamento? ObterAnexo(int id)=>service.ObterAnexo(id);
    public IReadOnlyList<XAlvoResumo> BuscarAlvos(string termo)=>service.BuscarAlvos(termo);
    public IReadOnlyList<XPlanejamentoMapa> ListarMapa()=>service.ListarMapa();
    public IReadOnlyList<XPlanejamentoResumo> Listar(int? secaoId)=>service.Listar(secaoId);
    public void Excluir(int id,string versao,XAutorPlanejamento autor)=>service.Excluir(id,versao,autor);
    public int Salvar(PlanejamentoViewModel m, XAutorPlanejamento autor, IReadOnlyList<XAnexoAlvoEntrada> fotos, bool finalizar, IReadOnlyList<XArquivoPlanejamentoEntrada>? anexos=null)=>service.Salvar(m,autor,fotos,finalizar,anexos);
    public PlanejamentoViewModel? PrepararEdicao(int id)
    {
        var p=service.Obter(id); if(p==null)return null;
        return new PlanejamentoViewModel{ID=p.ID,Versao=Convert.ToBase64String(p.Versao),Titulo=p.Titulo,DataPrevista=p.DataPrevista,
            LocalBriefing=p.LocalBriefing,HorarioBriefingDOE=p.HorarioBriefingDOE,HorarioSaidaDOE=p.HorarioSaidaDOE,
            HorarioBriefingDP=p.HorarioBriefingDP,SocorristaAPH1=p.SocorristaAPH1,SocorristaAPH2=p.SocorristaAPH2,
            MotoristaVtrAPH=p.MotoristaVtrAPH,PrefixoVtrAPH=p.PrefixoVtrAPH,ResponsavelRelatorio=p.ResponsavelRelatorio,
            ResponsavelFotoMBA=p.ResponsavelFotoMBA,CoordenadaZPH=p.CoordenadaZPH,Link_Rota_DOE_Unidade_Apoio=p.Link_Rota_DOE_Unidade_Apoio,
            Link_Rota_DP_Desemb=p.Link_Rota_DP_Desemb,Link_Localizacao_Desemb=p.Link_Localizacao_Desemb,Link_Localizacao_Hospital_1=p.Link_Localizacao_Hospital_1,
            Link_Localizacao_Hospital_2=p.Link_Localizacao_Hospital_2,DistanciaRotaDOEUnidadeApoioKm=p.DistanciaRotaDOEUnidadeApoioKm,DuracaoRotaDOEUnidadeApoioMinutos=p.DuracaoRotaDOEUnidadeApoioMinutos,
            DistanciaRotaDPDesembKm=p.DistanciaRotaDPDesembKm,DuracaoRotaDPDesembMinutos=p.DuracaoRotaDPDesembMinutos,
            MBA=p.MBA,MP=p.MP,NumeroMBA=p.NumeroMBA,OrdemServico=p.OrdemServico,UnidadeApoio=p.UnidadeApoio,Objetivo=p.Objetivo,Endereco=p.Endereco,Referencia=p.Referencia,
            Link_Endereco_Alvo=p.Link_Endereco_Alvo,Latitude=p.Latitude,Longitude=p.Longitude,CanalViaturas=p.CanalViaturas,CanalOperadores=p.CanalOperadores,ApoioMedico=p.ApoioMedico,Particularidades=p.Particularidades,
            Alvos=p.Alvos.OrderBy(a=>a.ID).Select(a=>new XAlvoEntrada{AlvoID=a.AlvoID,Nome=a.Alvo.Nome,CPF=a.Alvo.CPF,Alcunha=a.Alvo.Alcunha,Codigo=a.Codigo,Observacoes=a.Observacoes}).ToList(),
            Itens=p.Itens.OrderBy(i=>i.ID).Select(i=>new XItemEntrada{Tipo=i.Tipo,Descricao=i.Descricao,DataHora=i.DataHora,Responsavel=i.Responsavel,Url=i.Url,DistanciaKm=i.DistanciaKm,DuracaoMinutos=i.DuracaoMinutos}).ToList(),
            Integrantes=p.Integrantes.OrderBy(i=>i.ID).Select(i=>new XIntegranteEntrada{OperadorID=i.OperadorID,ViaturaID=i.ViaturaID,Funcao=i.Funcao,Entrada=i.Entrada}).ToList()};
    }
}
