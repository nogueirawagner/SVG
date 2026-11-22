using SVG.App.Interfaces;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.Planejamento;
namespace SVG.App.Services;

public class PlanejamentoDocumentoAppService(IPlanejamentoService planejamentos, IGeradorPlanejamentoPdf gerador) : IPlanejamentoDocumentoAppService
{
    public XDocumentoPlanejamento? GerarPdf(int id, string urlBase)
    {
        var planejamento=planejamentos.Obter(id);
        if(planejamento==null) return null;
        var fotos=new Dictionary<int,AnexoAlvo>();
        foreach(var alvoId in planejamento.Alvos.Select(a=>a.AlvoID).Distinct())
        {
            var foto=planejamentos.ObterFoto(alvoId);
            if(foto!=null) fotos[alvoId]=foto;
        }
        // Mesma origem do título do Index, removendo somente caracteres inválidos em nomes de arquivo.
        var titulo=planejamento.ObterTituloExibicao();
        var nomeArquivo=new string(titulo.Select(c=>char.IsControl(c) || "<>:\"/\\|?*".Contains(c)?'-':c).ToArray()).TrimEnd(' ','.')+".pdf";
        return new XDocumentoPlanejamento(gerador.Gerar(planejamento,fotos,urlBase),nomeArquivo);
    }
}
