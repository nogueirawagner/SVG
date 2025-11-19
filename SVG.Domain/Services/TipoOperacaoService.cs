using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;

namespace SVG.Domain.Services
{
  public class TipoOperacaoService : ServiceBase<TipoOperacao>, ITipoOperacaoService
  {
    private readonly ITipoOperacaoRepository _repository;

    public TipoOperacaoService(ITipoOperacaoRepository repository)
        : base(repository)
    {
      _repository = repository;
    }
  }
}
