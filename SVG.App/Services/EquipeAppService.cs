using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class EquipeAppService : AppServiceBase<Equipe>, IEquipeAppService
  {
    private readonly IEquipeService _equipeService;

    public EquipeAppService(IEquipeService equipeService)
      : base(equipeService)
    {
      _equipeService = equipeService;
    }
  }
}
