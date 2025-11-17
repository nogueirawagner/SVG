using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class OperadorOperacaoAppService : AppServiceBase<OperadorOperacao>, IOperadorOperacaoAppService
  {
    private readonly IOperadorOperacaoService _operadorOperacaoService;

    public OperadorOperacaoAppService(IOperadorOperacaoService operadorOperacaoService)
      : base(operadorOperacaoService)
    {
      _operadorOperacaoService = operadorOperacaoService;
    }
  }
}
