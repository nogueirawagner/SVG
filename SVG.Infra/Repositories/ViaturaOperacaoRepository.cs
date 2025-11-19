using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.Repositories;

namespace SVG.Infra.Repositories
{
  public class ViaturaOperacaoRepository : RepositoryBase<ViaturaOperacao>, IViaturaOperacaoRepository
  {
    private readonly SQLServerContext _db;

    public ViaturaOperacaoRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }
  }
}
