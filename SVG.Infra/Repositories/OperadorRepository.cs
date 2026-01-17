using Microsoft.EntityFrameworkCore;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.TiposEstruturados.TiposOperador;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.FunctionsDB;
using SVG.Infra.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

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

      var results = new List<XDetalhamentoOperadorOperacao>();

      using var conn = _db.Database.GetDbConnection();
      using var cmd = conn.CreateCommand();
      cmd.CommandText = sql;
      cmd.CommandType = CommandType.Text;

      var param = cmd.CreateParameter();
      param.ParameterName = "@pOperadorId";
      param.Value = pOperadorId;
      cmd.Parameters.Add(param);

      if (conn.State != ConnectionState.Open)
        conn.Open();

      using var reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        results.Add(new XDetalhamentoOperadorOperacao
        {
          ID = reader.IsDBNull(reader.GetOrdinal("ID")) ? 0 : reader.GetInt32(reader.GetOrdinal("ID")),
          Matricula = reader.IsDBNull(reader.GetOrdinal("Matricula")) ? null : reader.GetString(reader.GetOrdinal("Matricula")),
          Nome = reader.IsDBNull(reader.GetOrdinal("Nome")) ? null : reader.GetString(reader.GetOrdinal("Nome")),
          Telefone = reader.IsDBNull(reader.GetOrdinal("Telefone")) ? null : reader.GetString(reader.GetOrdinal("Telefone")),
          Sessao = reader.IsDBNull(reader.GetOrdinal("Sessao")) ? null : reader.GetString(reader.GetOrdinal("Sessao")),
          TipoOperacao = reader.IsDBNull(reader.GetOrdinal("TipoOperacao")) ? null : reader.GetString(reader.GetOrdinal("TipoOperacao")),
          Peso = reader.IsDBNull(reader.GetOrdinal("Peso")) ? 0 : reader.GetInt32(reader.GetOrdinal("Peso")),
          QtdOperacoes = reader.IsDBNull(reader.GetOrdinal("QtdOperacoes")) ? 0 : reader.GetInt32(reader.GetOrdinal("QtdOperacoes")),
          SVG = reader.IsDBNull(reader.GetOrdinal("SVG")) ? false : reader.GetBoolean(reader.GetOrdinal("SVG"))
        });
      }

      return results;
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
					SUM(CASE WHEN qtd.SVG =1 THEN QtdOperacoes ELSE0 END) AS QtdOperacoesSVG,
					SUM(QtdOperacoes) QtdOperacoes,
					CEILING(
						(CAST(SUM(QtdOperacoes * Peso) AS FLOAT) / NULLIF(SUM(Peso),0)) *100
					) /100.0 AS MediaPonderada
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
				order by OperadorNome";

      var results = new List<XResumoOperadorOperacao>();

      using var conn = _db.Database.GetDbConnection();
      using var cmd = conn.CreateCommand();
      cmd.CommandText = sql;
      cmd.CommandType = CommandType.Text;

      if (conn.State != ConnectionState.Open)
        conn.Open();

      using var reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        results.Add(new XResumoOperadorOperacao
        {
          OperadorID = reader.IsDBNull(reader.GetOrdinal("OperadorID")) ? 0 : reader.GetInt32(reader.GetOrdinal("OperadorID")),
          OperadorNome = reader.IsDBNull(reader.GetOrdinal("OperadorNome")) ? null : reader.GetString(reader.GetOrdinal("OperadorNome")),
          Matricula = reader.IsDBNull(reader.GetOrdinal("Matricula")) ? null : reader.GetString(reader.GetOrdinal("Matricula")),
          Telefone = reader.IsDBNull(reader.GetOrdinal("Telefone")) ? null : reader.GetString(reader.GetOrdinal("Telefone")),
          Sessao = reader.IsDBNull(reader.GetOrdinal("Sessao")) ? null : reader.GetString(reader.GetOrdinal("Sessao")),
          QtdOperacoes = reader.IsDBNull(reader.GetOrdinal("QtdOperacoes")) ? 0 : reader.GetInt32(reader.GetOrdinal("QtdOperacoes")),
          QtdOperacoesSVG = reader.IsDBNull(reader.GetOrdinal("QtdOperacoesSVG")) ? 0 : reader.GetInt32(reader.GetOrdinal("QtdOperacoesSVG")),
          MediaPonderada = reader.IsDBNull(reader.GetOrdinal("MediaPonderada")) ? 0.0 : Convert.ToDouble(reader.GetValue(reader.GetOrdinal("MediaPonderada")))
        });
      }

      return results;
    }

    public IEnumerable<int> PegarOperadoresOperacao(int pOperacaoId)
    {
      var sql = @"select ID from OperadorOperacao where OperacaoID = @pOperacaoID";
      var results = new List<int>();

      var conn = _db.Database.GetDbConnection();
      try
      {
        if (conn.State != System.Data.ConnectionState.Open)
          conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.Parameters.Add(new SqlParameter("@pOperacaoID", pOperacaoId));

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
          if (!reader.IsDBNull(0)) results.Add(reader.GetInt32(0));
        }
      }
      finally
      {
        try { if (conn.State == System.Data.ConnectionState.Open) conn.Close(); } catch { }
      }

      return results;
    }
  }
}
