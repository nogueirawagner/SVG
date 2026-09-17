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

    public IEnumerable<Viatura> PegarDisponiveis()
    {
      return _viaturaRepository.PegarDisponiveis();
    }

    public IEnumerable<Viatura> PegarPorSecao(int pSecaoID)
    {
      return _viaturaRepository.PegarPorSecao(pSecaoID);
    }

    public IEnumerable<Viatura> PegarViaturas()
    {
      return _viaturaRepository.PegarViaturas();
    }
  }
}
