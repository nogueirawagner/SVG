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

    public async Task<IEnumerable<XBiSerie>> ObterAdesaoSvgAsync(XPeriodicidade periodicidade)
    {
      var cacheKey = CacheKey(
        nameof(ObterAdesaoSvgAsync),
        periodicidade);

      if (_cache.TryGetValue(cacheKey, out IEnumerable<XBiSerie> cached))
        return cached;

      var view = ViewPorPeriodo("vw_dm_adesao_svg", periodicidade.Periodo);

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
          new SqlParameter("@ano", (object?)periodicidade.Ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)periodicidade.SecaoId ?? DBNull.Value),
          new SqlParameter("@operadorId", (object?)periodicidade.OperadorId ?? DBNull.Value)
      ).ToListAsync();

      _cache.Set(
       cacheKey,
       result,
       TimeSpan.FromMinutes(5)
      );

      return result;
    }

    public async Task<XBiDashboard> ObterDashboardAsync(XPeriodicidade periodicidade)
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
          new SqlParameter("@ano", (object?)periodicidade.Ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)periodicidade.SecaoId ?? DBNull.Value),
          new SqlParameter("@operadorId", (object?)periodicidade.OperadorId ?? DBNull.Value)
      ).SingleAsync();
    }


    public async Task<IEnumerable<XBiSerie>> ObterOperacoesAsync(XPeriodicidade periodicidade)
    {
      var cacheKey = CacheKey(
       nameof(ObterOperacoesAsync),
       periodicidade);

      if (_cache.TryGetValue(cacheKey, out IEnumerable<XBiSerie> cached))
        return cached;

      var view = ViewPorPeriodo("vw_dm_operacao", periodicidade.Periodo);

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
          new SqlParameter("@ano", (object?)periodicidade.Ano ?? DBNull.Value)
      ).ToListAsync();

      _cache.Set(
        cacheKey,
        result,
        TimeSpan.FromMinutes(5)
      );

      return result;
    }


    public async Task<IEnumerable<XBiSerie>> ObterParticipacaoOperadorAsync(XPeriodicidade periodicidade)
    {
      var cacheKey = CacheKey(
       nameof(ObterParticipacaoOperadorAsync),
       periodicidade);

      if (_cache.TryGetValue(cacheKey, out IEnumerable<XBiSerie> cached))
        return cached;

      var view = ViewPorPeriodo("vw_dm_participacao_operador", periodicidade.Periodo);

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
          new SqlParameter("@ano", (object?)periodicidade.Ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)periodicidade.SecaoId ?? DBNull.Value),
          new SqlParameter("@operadorId", (object?)periodicidade.OperadorId ?? DBNull.Value)
      ).ToListAsync();

      _cache.Set(
        cacheKey,
        result,
        TimeSpan.FromMinutes(5)
      );

      return result;
    }


    public async Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(XPeriodicidade periodicidade)
    {
      var cacheKey = CacheKey(
       nameof(ObterTopOperadoresAsync),
       periodicidade);

      var view = ViewPorPeriodo("vw_dm_top_operadores", periodicidade.Periodo);

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
          new SqlParameter("@ano", (object?)periodicidade.Ano ?? DBNull.Value),
          new SqlParameter("@secaoId", (object?)periodicidade.SecaoId ?? DBNull.Value)
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
      XPeriodicidade periodicidade)
    {
      return $"BI:{metodo}:{periodicidade.Periodo}:{periodicidade.Ano}:{periodicidade.SecaoId}:{periodicidade.OperadorId}";
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
