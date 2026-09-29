using SVG.Domain.TiposEstruturados;
using SVG.Domain.TiposEstruturados.TiposOperador;

namespace SVG.Domain.Interfaces.Services
{
  public interface IElegibilidadeSVGService
  {
    XResultadoElegibilidadeSVG VerificarElegibilidade(
      int pOperadorID,
      DateTime pDataReferencia);
  }
}