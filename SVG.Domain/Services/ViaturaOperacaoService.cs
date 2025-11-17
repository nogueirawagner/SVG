using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;

namespace SVG.Domain.Services
{
  public class ViaturaOperacaoService : ServiceBase<ViaturaOperacao>, IViaturaOperacaoService
  {
    private readonly IViaturaOperacaoRepository _viaturaOperacaoRepository;

    public ViaturaOperacaoService(IViaturaOperacaoRepository viaturaOperacaoRepository)
      : base(viaturaOperacaoRepository)
    {
      _viaturaOperacaoRepository = viaturaOperacaoRepository;
    }
  }
}
