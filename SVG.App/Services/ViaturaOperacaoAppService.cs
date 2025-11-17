using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class ViaturaOperacaoAppService : AppServiceBase<ViaturaOperacao>, IViaturaOperacaoAppService
  {
    private readonly IViaturaOperacaoService _viaturaOperacaoService;

    public ViaturaOperacaoAppService(IViaturaOperacaoService viaturaOperacaoService)
      : base(viaturaOperacaoService)
    {
      _viaturaOperacaoService = viaturaOperacaoService;
    }
  }
}
