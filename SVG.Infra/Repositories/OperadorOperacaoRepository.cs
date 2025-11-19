using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.Repositories;

namespace SVG.Infra.Repositories
{
  public class OperadorOperacaoRepository : RepositoryBase<OperadorOperacao>, IOperadorOperacaoRepository
  {
    private readonly SQLServerContext _db;

    public OperadorOperacaoRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }
  }
}
