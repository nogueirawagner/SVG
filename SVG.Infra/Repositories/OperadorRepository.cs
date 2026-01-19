using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.TiposEstruturados.TiposOperador;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.FunctionsDB;
using SVG.Infra.Repositories;
using System.CodeDom;
using System.Data.Entity;
using System.Data.SqlClient;

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

    public IEnumerable<XDetalhamentoOperadorOperacao> PegarDetalhamentoOperador(int pOperadorId)
    {
      var sql = @"
			WITH CTE_Operacao AS (
				select 
					op.ID,
					op.TipoOperacaoID
				from Operacao op 
				)

				, CTE_QtdOperacoesOperadores AS (
				select 
					oo.OperadorID,
					COUNT(*) QtdOperacoes,
					op.TipoOperacaoID,
					tp.Peso,
					tp.Nome,
					oo.SVG
				from CTE_Operacao op
					join OperadorOperacao oo 
						on oo.OperacaoID = op.ID 
					join TipoOperacao tp on tp.ID = op.TipoOperacaoID
				where oo.OperadorID = @pOperadorId
				group by 
					oo.OperadorID,
					op.TipoOperacaoID,
					tp.Peso,
					tp.Nome,
					oo.SVG
				)

				, CTE_Resultado AS (
				select 
					op.ID, 
					op.Matricula,
					op.Nome,
					op.Telefone,
					s.Nome Sessao,
					t.Nome TipoOperacao,
					t.Peso,
					qtd.QtdOperacoes,
					qtd.SVG
				from CTE_QtdOperacoesOperadores qtd
					join Operador op on op.ID = qtd.OperadorID
					join Sessao s on s.ID = op.SessaoID
					join TipoOperacao t on t.ID = qtd.TipoOperacaoID
				)

				select * from CTE_Resultado
				order by TipoOperacao";

      return _db.Database.SqlQuery<XDetalhamentoOperadorOperacao>(sql,
        new SqlParameter("@pOperadorId", pOperadorId));
    }

    public IEnumerable<XResumoOperadorOperacao> PegarResumoOperador()
    {
      var sql = @"
				WITH CTE_Operacao AS (
				select 
					op.ID,
					op.TipoOperacaoID
				from Operacao op 
				)

				, CTE_QtdOperacoesOperadores AS (
				select 
					oo.OperadorID,
					COUNT(*) QtdOperacoes,
					op.TipoOperacaoID,
					tp.Peso,
					tp.Nome,
					oo.SVG
				from CTE_Operacao op
					join OperadorOperacao oo 
						on oo.OperacaoID = op.ID 
					join TipoOperacao tp on tp.ID = op.TipoOperacaoID
				group by 
					oo.OperadorID,
					op.TipoOperacaoID,
					tp.Peso,
					tp.Nome,
					oo.SVG
				)

				, CTE_MediaOperadores AS (

				SELECT 
					OperadorID,
					SUM(CASE WHEN qtd.SVG = 1 THEN QtdOperacoes ELSE 0 END) AS QtdOperacoesSVG,
					SUM(QtdOperacoes) QtdOperacoes,
					CEILING(
								(CAST(SUM(QtdOperacoes * Peso) AS FLOAT) / NULLIF(SUM(Peso), 0)) * 100
						) / 100.0 AS MediaPonderada
				FROM CTE_QtdOperacoesOperadores qtd
					join Operador op on op.ID = qtd.OperadorID
				GROUP BY OperadorID
				)

				, CTE_Resultado AS (
				select 
					op.ID OperadorID, 
					op.Nome OperadorNome, 
					op.Matricula,
					op.Telefone,
					s.Nome Sessao,
					qtd.QtdOperacoes,
					qtd.QtdOperacoesSVG,
					qtd.MediaPonderada
				from CTE_MediaOperadores qtd
					join Operador op on op.ID = qtd.OperadorID
					join Sessao s on s.ID = op.SessaoID
				)

				select * from CTE_Resultado r
				order by OperadorNome 
          ";

      return _db.Database.SqlQuery<XResumoOperadorOperacao>(sql);
    }

    public IEnumerable<int> PegarOperadoresOperacao(int pOperacaoId)
    {
			var sql = @"select ID from OperadorOperacao where OperacaoID = @pOperacaoID";

      return _db.Database.SqlQuery<int>(sql, 
				new SqlParameter("@pOperacaoID", pOperacaoId));
    }

    public XOperadorSelecionado ObterPorMatriculaNormalizada(string matriculaNormalizada)
    {
      const string sql = @"
        SELECT *
        FROM Operador
        WHERE REPLACE(REPLACE(Matricula, '.', ''), '-', '') = @matricula";

      return _db.Database
          .SqlQuery<XOperadorSelecionado>(
              sql,
              new SqlParameter("@matricula", matriculaNormalizada)
          )
          .FirstOrDefault();
    }
  }
}
