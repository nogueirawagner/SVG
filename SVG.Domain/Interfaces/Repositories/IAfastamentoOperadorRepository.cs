using SVG.Domain.Entities;

namespace SVG.Domain.Interfaces.Repositories
{
  public interface IAfastamentoOperadorRepository
    : IRepositoryBase<AfastamentoOperador>
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