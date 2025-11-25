using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.FunctionsDB;
using SVG.Infra.Repositories;

namespace SVG.Infra.Repositories
{
  public class OperadorRepository : RepositoryBase<Operador>, IOperadorRepository
  {
    private readonly SQLServerContext _db;

    public OperadorRepository(SQLServerContext dbContext)
        : base(dbContext)
    {
      _db = dbContext;
    }

    public IEnumerable<Operador> PesquisarAlunosPorPalavras(string pTermo)
    {
      var pChaves = new List<string>();
      var where = XFullText.MontarCondicao(pTermo, "Nome", out pChaves);

      var sql = @"SELECT * FROM Aluno WHERE {0} and Concorrencia = '{1}' and Cargo = '{2}' ORDER BY Posicao";
      //var sql = @"SELECT * FROM Aluno WHERE {0} and Concorrencia = '{1}' and Cargo = '{2}' ORDER BY PosicaoProvisoria";

      sql = string.Format(sql, where);
      return _db.Database.SqlQuery<Operador>(sql);
    }
  }
}
