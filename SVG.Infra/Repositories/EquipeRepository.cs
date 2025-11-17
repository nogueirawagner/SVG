using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.Repositories;

namespace GestaoDDD.Infra.Data.Repositories
{
  public class EquipeRepository : RepositoryBase<Equipe>, IEquipeRepository
  {
    private readonly SQLServerContext _db;

    public EquipeRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }
  }
}
