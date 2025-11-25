using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class OperacaoAppService : AppServiceBase<Operacao>, IOperacaoAppService
  {
    private readonly IOperacaoService _operacaoService;

    public OperacaoAppService(IOperacaoService operacaoService)
      : base(operacaoService)
    {
      _operacaoService = operacaoService;
    }

    public IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas)
    {
      return _operacaoService.PegarOperadoresSVG(pOperadorIDs, pDataLimite, pQtdVagas);
    }
  }
}
