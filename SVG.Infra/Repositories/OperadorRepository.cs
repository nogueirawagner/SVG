using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.TiposEstruturados.Operador;
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

    public IEnumerable<ResumoOperadorOperacao> PegarResumoOperador()
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
					SUM((
						CASE 
							WHEN qtd.SVG = 1 THEN 1 ELSE 0
						END
					)) QtdOperacoesSVG,
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

      return _db.Database.SqlQuery<ResumoOperadorOperacao>(sql).ToList();
    }
  }
}

/*
 
 public IEnumerable<ResumoOperadorOperacao> ObterResumoOperacoes()
{
    var sql = @"
        SELECT * 
        FROM CTE_Resultado
        ORDER BY Nome
    ";

    using (var conn = _db.Database.Connection)
    {
        if (conn.State != ConnectionState.Open)
            conn.Open();

        using (var cmd = conn.CreateCommand())
        {
            cmd.CommandText = sql;

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    yield return new ResumoOperadorOperacao
                    {
                        OperadorID = reader.GetInt32(reader.GetOrdinal("OperadorID")),
                        Nome = reader.GetString(reader.GetOrdinal("Nome")),
                        Matricula = reader.GetString(reader.GetOrdinal("Matricula")),
                        Telefone = reader.GetString(reader.GetOrdinal("Telefone")),
                        Sessao = reader.GetString(reader.GetOrdinal("Sessao")),
                        QtdOperacoes = reader.GetInt32(reader.GetOrdinal("QtdOperacoes")),
                        QtdOperacaoSVG = reader.GetInt32(reader.GetOrdinal("QtdOperacaoSVG")),
                        Media = reader.GetDecimal(reader.GetOrdinal("Media"))
                    };
                }
            }
        }
    }
}

 */