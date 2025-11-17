using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;

namespace SVG.Domain.Services
{
  public class ViaturaService : ServiceBase<Viatura>, IViaturaService
  {
    private readonly IViaturaRepository _viaturaRepository;

    public ViaturaService(IViaturaRepository viaturaRepository)
      : base(viaturaRepository)
    {
      _viaturaRepository = viaturaRepository;
    }
  }
}
