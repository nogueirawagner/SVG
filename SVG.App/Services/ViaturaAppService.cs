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

    public IEnumerable<Viatura> PegarDisponiveis()
    {
      return _viaturaService.PegarDisponiveis();  
    }

    public IEnumerable<Viatura> PegarPorSecao(int pSecaoID)
    {
      return _viaturaService.PegarPorSecao(pSecaoID);
    }

    public IEnumerable<Viatura> PegarViaturas()
    {
      return _viaturaService.PegarViaturas();
    }
  }
}
