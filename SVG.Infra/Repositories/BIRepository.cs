using Microsoft.Extensions.Caching.Memory;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.TiposEstruturados.BI;
using SVG.Infra.Context.SQLServer;
using System.Data.SqlClient;
using System.Runtime.Caching;

namespace SVG.Infra.Repositories
{
  public class BIRepository : RepositoryBase<Operacao>, IBIRepository
  {
    private readonly SQLServerContext _db;
    private readonly IMemoryCache _cache;

    public BIRepository(
      SQLServerContext dbContext,
      IMemoryCache cache)
      : base(dbContext)
    {
      _db = dbContext;
      _cache = cache;
    }

    public async Task<IEnumerable<XBiSerie>> ObterAdesaoSvgAsync(
      string periodo,
      int? ano,
      int? secaoId,
      int? operadorId)
    {
      var cacheKey = CacheKey(
        nameof(ObterAdesaoSvgAsync),
        periodo, ano, secaoId, operadorId);

      if (_cache.TryGetValue(cacheKey, out IEnumerable<XBiSerie> cached))
        return cached;

      var view = ViewPorPeriodo("vw_dm_adesao_svg", periodo);

      var sql = $@"
        SELECT
            DataSK,
            Label,
            Total
        FROM {view}
        WHERE (@ano IS NULL OR YEAR(DataSK) = @ano)
          
        ORDER BY DataSK
    ";

      var result = await _db.Database.SqlQuery<XBiSerie>(
          sql,
          new SqlParameter("@ano", (object?)ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)secaoId ?? DBNull.Value),
          new SqlParameter("@operadorId", (object?)operadorId ?? DBNull.Value)
      ).ToListAsync();

      _cache.Set(
       cacheKey,
       result,
       TimeSpan.FromMinutes(5)
      );

      return result;
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
        WHERE (@ano IS NULL OR YEAR(DataSK) = @ano)

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
      var cacheKey = CacheKey(
       nameof(ObterOperacoesAsync),
       periodo, ano, secaoId, operadorId);

      if (_cache.TryGetValue(cacheKey, out IEnumerable<XBiSerie> cached))
        return cached;

      var view = ViewPorPeriodo("vw_dm_operacao", periodo);

      var sql = $@"
        SELECT
            DataSK,
            Label,
            Total
        FROM {view}
        WHERE (@ano IS NULL OR YEAR(DataSK) = @ano)
        ORDER BY DataSK
    ";

      var result = await _db.Database.SqlQuery<XBiSerie>(
          sql,
          new SqlParameter("@ano", (object?)ano ?? DBNull.Value)
      ).ToListAsync();

      _cache.Set(
        cacheKey,
        result,
        TimeSpan.FromMinutes(5)
      );

      return result;
    }


    public async Task<IEnumerable<XBiSerie>> ObterParticipacaoOperadorAsync(
    string periodo,
    int? ano,
    int? secaoId,
    int? operadorId)
    {
      var cacheKey = CacheKey(
       nameof(ObterParticipacaoOperadorAsync),
       periodo, ano, secaoId, operadorId);

      if (_cache.TryGetValue(cacheKey, out IEnumerable<XBiSerie> cached))
        return cached;

      var view = ViewPorPeriodo("vw_dm_participacao_operador", periodo);

      var sql = $@"
        SELECT
            DataSK,
            Label,
            Total
        FROM {view}
        WHERE (@ano IS NULL OR YEAR(DataSK) = @ano)
          
        ORDER BY DataSK
    ";

      var result = await _db.Database.SqlQuery<XBiSerie>(
          sql,
          new SqlParameter("@ano", (object?)ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)secaoId ?? DBNull.Value),
          new SqlParameter("@operadorId", (object?)operadorId ?? DBNull.Value)
      ).ToListAsync();

      _cache.Set(
        cacheKey,
        result,
        TimeSpan.FromMinutes(5)
      );

      return result;
    }


    public async Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(
     string periodo,
     int? ano,
     int? secaoId)
    {
      var cacheKey = CacheKey(
       nameof(ObterTopOperadoresAsync),
       periodo, ano, secaoId);

      var view = ViewPorPeriodo("vw_dm_top_operadores", periodo);

      var sql = $@"
        SELECT
            OperadorId,
            Operador,
            TotalParticipacoes
        FROM {view}
        WHERE (@ano IS NULL OR YEAR(DataSK) = @ano)
          
        ORDER BY TotalParticipacoes DESC
    ";

      var result = await _db.Database.SqlQuery<XTopOperador>(
          sql,
          new SqlParameter("@ano", (object?)ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)secaoId ?? DBNull.Value)
      ).ToListAsync();

      _cache.Set(
        cacheKey,
        result,
        TimeSpan.FromMinutes(5)
      );

      return result;
    }

    private static string CacheKey(
    string metodo,
    string periodo,
    int? ano,
    int? secaoId,
    int? operadorId = null)
    {
      return $"BI:{metodo}:{periodo}:{ano}:{secaoId}:{operadorId}";
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

    public async Task<IEnumerable<int>> ObterAnosAsync()
    {
      var sql = @"
        SELECT DISTINCT YEAR(o.DataHora) AS Ano
        FROM Operacao o
        ORDER BY Ano;
    ";

      return (await _db.Database
          .SqlQuery<XBiAno>(sql)
          .ToListAsync())
          .Select(x => x.Ano);
    }

    public async Task<XBiDataRange> ObterRangeDatasAsync()
    {
      var sql = @"
        SELECT 
            MIN(DataHora) AS DataMin,
            MAX(DataHora) AS DataMax
        FROM Operacao;
    ";

      return await _db.Database
          .SqlQuery<XBiDataRange>(sql)
          .FirstAsync();
    }

    public async Task<IEnumerable<XBiOperadorFiltro>> ObterOperadoresAsync()
    {
      var sql = @"
        SELECT
            o.ID        AS OperadorID,
            o.Nome      AS Nome,
            s.ID        AS SessaoID,
            s.Nome      AS SessaoNome
        FROM Operador o
        JOIN Sessao s ON s.ID = o.SessaoID
        ORDER BY s.Nome, o.Nome;
    ";

      return await _db.Database
          .SqlQuery<XBiOperadorFiltro>(sql)
          .ToListAsync();
    }
  }
}
