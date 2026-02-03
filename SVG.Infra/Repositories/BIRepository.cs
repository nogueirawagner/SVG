using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.TiposEstruturados.BI;
using SVG.Infra.Context.SQLServer;
using System.Data.SqlClient;

namespace SVG.Infra.Repositories
{
  public class BIRepository : RepositoryBase<Operacao>, IBIRepository
  {
    private readonly SQLServerContext _db;

    public BIRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }

    private static string ViewPorPeriodo(string baseView, string periodo)
    {
      return periodo switch
      {
        "mensal" => $"{baseView}_mensal",
        "bimestral" => $"{baseView}_bimestral",
        "trimestral" => $"{baseView}_trimestral",
        "semestral" => $"{baseView}_semestral",
        _ => $"{baseView}_mensal"
      };
    }

    public async Task<IEnumerable<XBiSerie>> ObterAdesaoSvgAsync(
      string periodo, 
      int? ano, 
      int? secaoId, 
      int? operadorId)
    {
      var view = ViewPorPeriodo("vw_dm_adesao_svg", periodo);

      var sql = @"
        SELECT
            DataSK,
            Label,
            Total
        FROM @view
        WHERE (@ano IS NULL OR YEAR(DataSK) = @ano)
          AND (@secaoId IS NULL OR SessaoID = @secaoId)
          AND (@operadorId IS NULL OR OperadorID = @operadorId)
        ORDER BY DataSK
    ";

      return await _db.Database.SqlQuery<XBiSerie>(
          sql,
          new SqlParameter("@ano", (object?)ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)secaoId ?? DBNull.Value),
          new SqlParameter("@operadorId", (object?)operadorId ?? DBNull.Value),
          new SqlParameter("@view", view)
      ).ToListAsync();
    }

    public async Task<XBiDashboard> ObterDashboardAsync(
      string periodo, 
      int? ano, 
      int? secaoId, 
      int? operadorId)
    {
      var sql = @"
        SELECT
            COUNT(DISTINCT o.OperacaoID)               AS TotalOperacoes,
            COUNT(DISTINCT p.OperadorID)               AS TotalOperadores,
            SUM(CASE WHEN p.SVG = 1 THEN 1 ELSE 0 END) AS TotalSvg,
            CAST(
                100.0 * SUM(CASE WHEN p.SVG = 1 THEN 1 ELSE 0 END)
                / NULLIF(COUNT(*), 0)
                AS decimal(5,2)
            ) AS PercentualSvg
        FROM vw_dm_operacao o
        JOIN vw_dm_participacao_operador p
          ON p.OperacaoID = o.OperacaoID
        WHERE (@ano IS NULL OR YEAR(o.DataSK) = @ano)
          AND (@secaoId IS NULL OR p.SessaoID = @secaoId)
          AND (@operadorId IS NULL OR p.OperadorID = @operadorId)
    ";

      return await _db.Database.SqlQuery<XBiDashboard>(
          sql,
          new SqlParameter("@ano", (object?)ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)secaoId ?? DBNull.Value),
          new SqlParameter("@operadorId", (object?)operadorId ?? DBNull.Value)
      ).SingleAsync();
    }


    public async Task<IEnumerable<XBiSerie>> ObterOperacoesAsync(
     string periodo, 
     int? ano, 
     int? secaoId, 
     int? operadorId)
    {
      var view = ViewPorPeriodo("vw_dm_operacao", periodo);

      var sql = @"
        SELECT
            DataSK,
            Label,
            Total
        FROM @view
        WHERE (@ano IS NULL OR YEAR(DataSK) = @ano)
        ORDER BY DataSK
    ";

      return await _db.Database.SqlQuery<XBiSerie>(
          sql,
          new SqlParameter("@ano", (object?)ano ?? DBNull.Value),
          new SqlParameter("@view", view)
      ).ToListAsync();
    }


    public async Task<IEnumerable<XBiSerie>> ObterParticipacaoOperadorAsync(
    string periodo, 
    int? ano, 
    int? secaoId, 
    int? operadorId)
    {
      var view = ViewPorPeriodo("vw_dm_participacao_operador", periodo);

      var sql = @"
        SELECT
            DataSK,
            Label,
            Total
        FROM @view
        WHERE (@ano IS NULL OR YEAR(DataSK) = @ano)
          AND (@secaoId IS NULL OR SessaoID = @secaoId)
          AND (@operadorId IS NULL OR OperadorID = @operadorId)
        ORDER BY DataSK
    ";

      return await _db.Database.SqlQuery<XBiSerie>(
          sql,
          new SqlParameter("@ano", (object?)ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)secaoId ?? DBNull.Value),
          new SqlParameter("@operadorId", (object?)operadorId ?? DBNull.Value),
          new SqlParameter("@view", view)
      ).ToListAsync();
    }


    public async Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(
     string periodo, 
     int? ano, 
     int? secaoId)
    {
      var view = ViewPorPeriodo("vw_dm_top_operadores", periodo);

      var sql = @"
        SELECT
            OperadorId,
            Operador,
            TotalParticipacoes
        FROM @view
        WHERE (@ano IS NULL OR YEAR(DataSK) = @ano)
          AND (@secaoId IS NULL OR SessaoID = @secaoId)
        ORDER BY TotalParticipacoes DESC
    ";

      return await _db.Database.SqlQuery<XTopOperador>(
          sql,
          new SqlParameter("@ano", (object?)ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)secaoId ?? DBNull.Value),
          new SqlParameter("@view", view)
      ).ToListAsync();
    }

  }
}
