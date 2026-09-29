using SVG.Domain.Entities;

namespace SVG.Domain.Interfaces.Services
{
  public interface IImpedimentoOperadorService
    : IServiceBase<ImpedimentoOperador>
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
  }
}