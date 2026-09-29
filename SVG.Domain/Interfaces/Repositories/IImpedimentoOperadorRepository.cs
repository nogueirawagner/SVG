using SVG.Domain.Entities;

namespace SVG.Domain.Interfaces.Repositories
{
  public interface IImpedimentoOperadorRepository
    : IRepositoryBase<ImpedimentoOperador>
  {
    IEnumerable<ImpedimentoOperador> PegarImpedimentos();

    IEnumerable<ImpedimentoOperador> PegarPorPeriodo(
      DateTime pDataInicio,
      DateTime pDataFim);

    IEnumerable<ImpedimentoOperador> PegarPorOperadorEData(
      int pOperadorID,
      DateTime pData);

    bool ExisteImpedimentoNoPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime? pDataFim,
      int? pImpedimentoOperadorID = null);

    IEnumerable<ImpedimentoOperador> PegarPorOperadorEPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime pDataFim);
  }
}