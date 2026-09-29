using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class AfastamentoOperadorAppService
    : AppServiceBase<AfastamentoOperador>, IAfastamentoOperadorAppService
  {
    private readonly IAfastamentoOperadorService _afastamentoOperadorService;

    public AfastamentoOperadorAppService(
      IAfastamentoOperadorService afastamentoOperadorService)
      : base(afastamentoOperadorService)
    {
      _afastamentoOperadorService = afastamentoOperadorService;
    }

    public IEnumerable<AfastamentoOperador> PegarAfastamentos()
    {
      return _afastamentoOperadorService.PegarAfastamentos();
    }

    public IEnumerable<AfastamentoOperador> PegarPorPeriodo(
      DateTime pDataInicio,
      DateTime pDataFim)
    {
      return _afastamentoOperadorService
        .PegarPorPeriodo(pDataInicio, pDataFim);
    }

    public bool ExisteAfastamentoNoPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime pDataFim,
      int? pAfastamentoOperadorID = null)
    {
      return _afastamentoOperadorService.ExisteAfastamentoNoPeriodo(
        pOperadorID,
        pDataInicio,
        pDataFim,
        pAfastamentoOperadorID);
    }

    public IEnumerable<AfastamentoOperador> PegarPorOperadorEData(
      int pOperadorID,
      DateTime pData)
    {
      return _afastamentoOperadorService
        .PegarPorOperadorEData(pOperadorID, pData);
    }
  }
}