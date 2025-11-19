using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;

namespace SVG.Infra.Repositories
{
  public class TipoOperacaoRepository : RepositoryBase<TipoOperacao>, ITipoOperacaoRepository
  {
    public TipoOperacaoRepository(SQLServerContext dbContext)
        : base(dbContext)
    {
    }
  }
}
