using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class ViaturaAppService : AppServiceBase<Viatura>, IViaturaAppService
  {
    private readonly IViaturaService _viaturaService;

    public ViaturaAppService(IViaturaService viaturaService)
      : base(viaturaService)
    {
      _viaturaService = viaturaService;
    }
  }
}
