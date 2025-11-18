using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;

namespace SVG.Domain.Services
{
  public class SessaoService : ServiceBase<Sessao>, ISessaoService
  {
    private readonly ISessaoRepository _SessaoRepository;

    public SessaoService(ISessaoRepository SessaoRepository)
      : base(SessaoRepository)
    {
      _SessaoRepository = SessaoRepository;
    }
  }
}
