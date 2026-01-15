using Microsoft.EntityFrameworkCore;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.TiposEstruturados.TiposOperacao;
using SVG.Domain.TiposEstruturados.TiposOperador;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.Repositories;
using Microsoft.Data.SqlClient;
using System.Linq;

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

    public IEnumerable<XCandidatosOperacaoSVG> PegaCandidatoSVG(int pOperacaoID)
    {
      var sql = @"
            select 
	            c.OperacaoID, 
	            c.OperadorID,
	            o.Nome,
	            o.Matricula
            from CandidatoSVGOperacao c
	            join Operador o on o.ID = c.OperadorID
            where c.OperacaoID = @pOperacaoID";

      // EF Core pattern: map to a keyless entity and execute raw SQL via FromSqlRaw
      return _db.Set<XCandidatosOperacaoSVG>()
       .FromSqlRaw(sql, new SqlParameter("@pOperacaoID", pOperacaoID))
       .AsNoTracking()
       ;
    }

    public void InsereCandidatoSVG(int pOperacaoID, int pOperadorID)
    {
      _db.Database.ExecuteSqlRaw(@"
        IF NOT EXISTS (
            SELECT 1
            FROM CandidatoSVGOperacao
            WHERE OperadorID = @pOperadorID
              AND OperacaoID = @pOperacaoID
        )
        BEGIN
            INSERT INTO CandidatoSVGOperacao (OperadorID, OperacaoID, DataHoraCriacao)
            VALUES (@pOperadorID, @pOperacaoID, GETDATE())
        END",
       new SqlParameter("@pOperacaoID", pOperacaoID),
       new SqlParameter("@pOperadorID", pOperadorID)
      );
    }

    public void RemoveCandidatoSVG(int pOperacaoID, int pOperadorID)
    {
      _db.Database.ExecuteSqlRaw(@"
          DELETE FROM CandidatoSVGOperacao 
          WHERE OperacaoID = @pOperacaoID 
            and OperadorID = @pOperadorID", 
        new SqlParameter("@pOperacaoID", pOperacaoID),
        new SqlParameter("@pOperadorID", pOperadorID)
      );
    }

    public IEnumerable<XOperacoesSVGAberto> PegarOperacoesSVGAberto()
    {
      var sql = @"
          select 
	          o.ID, 
            o.DataHoraCriacao,
	          o.DataHora,
	          COALESCE(o.DataHoraInicio, o.DataHora) DataHoraInicio,
	          o.DataHoraFim,
	          t.Nome TipoOperacao,
	          o.QtdVagasRestantes
          from Operacao o
	          join TipoOperacao t on t.ID = o.TipoOperacaoID
          where SvgAberto = 1
          order by DataHoraCriacao desc, DataHoraInicio desc, DataHoraFim desc
        ";
      return _db.Set<XOperacoesSVGAberto>()
       .FromSqlRaw(sql)
       .AsNoTracking()
       ;
    }

    public IEnumerable<XOperacoesRealizadas> PegarOperacoesRealizadas()
    {
      var sql = @"
        select 
          o.ID,
          o.DataHoraCriacao,
          o.DataHora,
          o.Objeto,
          REPLACE(OrdemServico, 'OS ', '') OrdemServico,
          o.Coordenador,
          t.Nome TipoOperacao, 
          o.SvgAberto,
          o.QtdVagasRestantes,
          o.DataHoraFim
        from Operacao o
          join TipoOperacao t on t.ID = o.TipoOperacaoID
        order by DataHoraCriacao desc
        ";

      return _db.Set<XOperacoesRealizadas>()
       .FromSqlRaw(sql)
       .AsNoTracking()
       ;
    }

    public IEnumerable<XOperacoesRealizadas> ListarOperacoesPorOrdemServico(string pOrdemServico)
    {
      var sql = @"
        select 
          o.ID,
          o.DataHoraCriacao,
          o.DataHoraInicio,
          o.Objeto,
          REPLACE(OrdemServico, 'OS ', '') OrdemServico,
          (select COUNT(*) from OperadorOperacao where OperacaoID = o.ID) QtdOperadores,
          o.Coordenador,
          t.Nome TipoOperacao, 
          o.SvgAberto,
          o.QtdVagasRestantes,
          o.DataHoraFim
        from Operacao o
          join TipoOperacao t on t.ID = o.TipoOperacaoID
        where contains(OrdemServico, @pOrdemServico)
        order by DataHoraCriacao desc
        ";

      return _db.Set<XOperacoesRealizadas>()
       .FromSqlRaw(sql, new SqlParameter("@pOrdemServico", pOrdemServico))
       .AsNoTracking()
       ;
    }

    public IEnumerable<XDetalhesOperacao> PegarDetalhesOperacao(int pOperacaoID)
    {
      var sql = @"
        select 
	        o.ID,
	        o.DataHoraCriacao,
	        o.DataHora,
	        o.Objeto,
          o.OrdemServico,
	        o.Coordenador,
	        t.Nome TipoOperacao,
	        op.ID OperadorID,
	        op.Nome NomeOperador,
	        op.Matricula,
	        op.Telefone,
	        oo.SVG,
	        s.Nome Sessao
        from Operacao o
	        join TipoOperacao t on t.ID = o.TipoOperacaoID
	        join OperadorOperacao oo on oo.OperacaoID = o.ID
	        join Operador op on op.ID = oo.OperadorID
	        join Sessao s on s.ID = op.SessaoID
        where o.ID = @pOperacaoID
        ";

      var raw = _db.Set<XDetalhesOperacao>()
       .FromSqlRaw(sql, new SqlParameter("@pOperacaoID", pOperacaoID))
       .AsNoTracking()
       ;

      foreach (var item in raw)
      {
        yield return new XDetalhesOperacao
        {
          ID = item.ID,
          DataHoraCriacao = item.DataHoraCriacao,
          DataHora = item.DataHora,
          Objeto = item.Objeto,
          OrdemServico = item.OrdemServico,
          Coordenador = item.Coordenador,
          TipoOperacao = item.TipoOperacao,
          OperadorID = item.OperadorID,
          NomeOperador = item.NomeOperador,
          Matricula = item.Matricula,
          Telefone = item.Telefone,
          SVG = item.SVG,
          Sessao = item.Sessao
        };
      }
    }

    public IEnumerable<XEscalaPlantao> PegarEscalaPlantao(DateTime pDataReferencia)
    {
      var sql = @"
        select * from fn_Escala_Plantao_PorData(@pDataReferencia) e
	        join Sessao s on s.ID = e.SecaoID
        order by dataPlantao
        ";
      return _db.Set<XEscalaPlantao>()
       .FromSqlRaw(sql, new SqlParameter("@pDataReferencia", pDataReferencia))
       .AsNoTracking()
       ;
    }

    public void AlterarSVGOperador(int pOperadorId, bool pSvg)
    {
      var op = _db.OperadorOperacao.FirstOrDefault(x => x.OperadorID == pOperadorId);

      if (op != null)
      {
        op.SVG = pSvg;
        _db.SaveChanges();
      }
    }

    public IEnumerable<XOperadorSelecionado> PegarOperadoresOperacaoResumido(int pOperacaoID)
    {
      var sql = @"
      select 
	      o.Nome, 
	      o.Matricula 
      from Operador o
	      join OperadorOperacao oo on oo.OperadorID = o.ID
      where oo.OperacaoID = @pOperacaoID";

      return _db.Set<XOperadorSelecionado>()
       .FromSqlRaw(sql, new SqlParameter("@pOperacaoID", pOperacaoID))
       .AsNoTracking()
       ;
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
	        where oo.OperadorID in ({0})
        group by 
	        oo.OperadorID,
	        op.TipoOperacaoID,
	        tp.Peso,
	        tp.Nome	
        )

        , CTE_OperadoresNaoOperou AS (
	        select 
            o.ID as OperadorID,
	        0 QtdOperacoes, 
	        NULL TipoOperacaoID,
	        0 Peso,
	        '' Nome 
        from Operador o
        left join OperadorOperacao oo 
            on o.ID = oo.OperadorID
            and oo.SVG = 1
        left join Operacao op 
            on op.ID = oo.OperacaoID
            and op.DataHora >= @pDataLimite
        where o.ID in ({0})
        group by o.ID
        having count(op.ID) = 0
        )

        , CTE_QuantitativoOperacoes AS (
        select * from CTE_QtdOperacoesOperadores
        union all
        select * from CTE_OperadoresNaoOperou
        )

        , CTE_MediaOperadores AS (

        SELECT 
            OperadorID,
            SUM(QtdOperacoes * Peso) AS SomaPonderada,
            SUM(Peso) AS SomaPesos,
	        COALESCE(
	        CEILING(
                (CAST(SUM(QtdOperacoes * Peso) AS FLOAT) / NULLIF(SUM(Peso), 0)) * 100
            ) / 100.0, 0) AS MediaPonderada
        FROM CTE_QuantitativoOperacoes
        GROUP BY OperadorID
        )

        , CTE_Resultado AS (
        select OperadorID from CTE_MediaOperadores
        order by MediaPonderada asc
        OFFSET 0 ROWS
        FETCH NEXT @pQtdVagas ROWS ONLY
        )

        select * from CTE_Resultado";

      var ids = string.Join(", ", pOperadorIDs);
      sql = string.Format(sql, ids);

      var results = new List<int>();

      var conn = _db.Database.GetDbConnection();
      try
      {
        if (conn.State != System.Data.ConnectionState.Open)
          conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        var paramData = new SqlParameter("@pDataLimite", pDataLimite);
        var paramQtd = new SqlParameter("@pQtdVagas", pQtdVagas);
        cmd.Parameters.Add(paramData);
        cmd.Parameters.Add(paramQtd);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
          if (!reader.IsDBNull(0))
            results.Add(reader.GetInt32(0));
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
