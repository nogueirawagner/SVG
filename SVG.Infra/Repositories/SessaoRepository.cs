using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.Repositories;

namespace SVG.Infra.Repositories
{
  public class SessaoRepository : RepositoryBase<Sessao>, ISessaoRepository
  {
    private readonly SQLServerContext _db;

    public SessaoRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }
  }
}
