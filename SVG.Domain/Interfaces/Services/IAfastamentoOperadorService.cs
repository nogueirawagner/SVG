using SVG.Domain.Entities;

namespace SVG.Domain.Interfaces.Services
{
  public interface IAfastamentoOperadorService
    : IServiceBase<AfastamentoOperador>
  {
    IEnumerable<AfastamentoOperador> PegarAfastamentos();

    IEnumerable<AfastamentoOperador> PegarPorPeriodo(
      DateTime pDataInicio,
      DateTime pDataFim);

    IEnumerable<AfastamentoOperador> PegarPorOperadorEData(
      int pOperadorID,
      DateTime pData);

    bool ExisteAfastamentoNoPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime pDataFim,
      int? pAfastamentoOperadorID = null);
  }
}