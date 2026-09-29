using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class ImpedimentoOperadorAppService
    : AppServiceBase<ImpedimentoOperador>, IImpedimentoOperadorAppService
  {
    private readonly IImpedimentoOperadorService _impedimentoOperadorService;

    public ImpedimentoOperadorAppService(
      IImpedimentoOperadorService impedimentoOperadorService)
      : base(impedimentoOperadorService)
    {
      _impedimentoOperadorService = impedimentoOperadorService;
    }

    public IEnumerable<ImpedimentoOperador> PegarImpedimentos()
    {
      return _impedimentoOperadorService.PegarImpedimentos();
    }

    public IEnumerable<ImpedimentoOperador> PegarPorPeriodo(
      DateTime pDataInicio,
      DateTime pDataFim)
    {
      return _impedimentoOperadorService
        .PegarPorPeriodo(pDataInicio, pDataFim);
    }

    public IEnumerable<ImpedimentoOperador> PegarPorOperadorEData(
      int pOperadorID,
      DateTime pData)
    {
      return _impedimentoOperadorService
        .PegarPorOperadorEData(pOperadorID, pData);
    }

    public bool ExisteImpedimentoNoPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime? pDataFim,
      int? pImpedimentoOperadorID = null)
    {
      return _impedimentoOperadorService.ExisteImpedimentoNoPeriodo(
        pOperadorID,
        pDataInicio,
        pDataFim,
        pImpedimentoOperadorID);
    }
  }
}