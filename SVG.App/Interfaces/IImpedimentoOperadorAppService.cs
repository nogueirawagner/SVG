using SVG.Domain.Entities;

namespace SVG.App.Interface
{
  public interface IImpedimentoOperadorAppService
    : IAppServiceBase<ImpedimentoOperador>
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