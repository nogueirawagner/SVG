using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;

namespace SVG.Domain.Services
{
  public class EquipeService : ServiceBase<Equipe>, IEquipeService
  {
    private readonly IEquipeRepository _equipeRepository;

    public EquipeService(IEquipeRepository equipeRepository)
      : base(equipeRepository)
    {
      _equipeRepository = equipeRepository;
    }
  }
}
