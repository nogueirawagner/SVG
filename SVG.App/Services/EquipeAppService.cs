using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class SessaoAppService : AppServiceBase<Sessao>, ISessaoAppService
  {
    private readonly ISessaoService _SessaoService;

    public SessaoAppService(ISessaoService SessaoService)
      : base(SessaoService)
    {
      _SessaoService = SessaoService;
    }
  }
}
