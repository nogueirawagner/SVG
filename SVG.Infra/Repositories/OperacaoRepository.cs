using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.Repositories;
using System.Data.SqlClient;

namespace SVG.Infra.Repositories
{
  public class OperacaoRepository : RepositoryBase<Operacao>, IOperacaoRepository
  {
    private readonly SQLServerContext _db;

    public OperacaoRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }

    public IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas)
    {
      string sql = @"
          WITH CTE_Operacao AS (
          select 
	          op.ID,
	          op.TipoOperacaoID
          from Operacao op 
          where op.DataHora >= @pDataLimite
          )

          , CTE_QtdOperacoesOperadores AS (
          select 
	          oo.OperadorID,
	          COUNT(*) QtdOperacoes,
	          op.TipoOperacaoID,
	          tp.Peso,
	          tp.Nome
          from CTE_Operacao op
	          join OperadorOperacao oo 
		          on oo.OperacaoID = op.ID 
			          and oo.SVG = 1
	          join TipoOperacao tp on tp.ID = op.TipoOperacaoID
          group by 
	          oo.OperadorID,
	          op.TipoOperacaoID,
	          tp.Peso,
	          tp.Nome
          )

          , CTE_MediaOperadores AS (

          SELECT 
              OperadorID,
              SUM(QtdOperacoes * Peso) AS SomaPonderada,
              SUM(Peso) AS SomaPesos,
	          CEILING(
                  (CAST(SUM(QtdOperacoes * Peso) AS FLOAT) / NULLIF(SUM(Peso), 0)) * 100
              ) / 100.0 AS MediaPonderada
          FROM CTE_QtdOperacoesOperadores
          GROUP BY OperadorID
          )


          --, CTE_DemonstrativoAnalitico AS (
          --select cte.* from CTE_MediaOperadores cte
          --where OperadorID in (34, 33, 48, 22, 8, 17, 12, 23, 40, 41, 42, 43, 44, 46, 47, 48, 18, 11, 24)
          --order by MediaPonderada asc
          --OFFSET 0 ROWS
          --FETCH NEXT @pQtdVagas ROWS ONLY
          --)

          , CTE_Resultado AS (
          select OperadorID from CTE_MediaOperadores
          where OperadorID in ({0})
          order by MediaPonderada asc
          OFFSET 0 ROWS
          FETCH NEXT @pQtdVagas ROWS ONLY
          )

          select * from CTE_Resultado";

      var ids = string.Join(", ", pOperadorIDs);
      sql = string.Format(sql, ids);


      return _db.Database.
         SqlQuery<int>(sql,
           new SqlParameter("@pDataLimite", pDataLimite),
           new SqlParameter("@pQtdVagas", pQtdVagas)
         ).ToList();
    }
  }
}
