using SVG.Domain.TiposEstruturados.Planejamento;
namespace SVG.App.Interfaces;
public interface IPlanejamentoDocumentoAppService
{
    XDocumentoPlanejamento? GerarPdf(int id, string urlBase);
}
