using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class TipoOperacaoAppService : AppServiceBase<TipoOperacao>, ITipoOperacaoAppService
  {
    private readonly ITipoOperacaoService _service;

    public TipoOperacaoAppService(ITipoOperacaoService service)
        : base(service)
    {
      _service = service;
    }
  }
}
