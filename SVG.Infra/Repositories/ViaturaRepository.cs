using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.Repositories;

namespace GestaoDDD.Infra.Data.Repositories
{
  public class ViaturaRepository : RepositoryBase<Viatura>, IViaturaRepository
  {
    private readonly SQLServerContext _db;

    public ViaturaRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }
  }
}
