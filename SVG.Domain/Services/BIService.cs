using Microsoft.Extensions.Caching.Memory;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.BI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Services
{
  public class BIService : ServiceBase<Operacao>, IBIService
  {
    private readonly IBIRepository _biRepository;
    private readonly IMemoryCache _cache;

    public BIService(
      IBIRepository biRepository,
      IMemoryCache cache
      )
      : base(biRepository)
    {
      _biRepository = biRepository;
      _cache = cache;
    }

    public Task<IEnumerable<XBiSerie>> ObterAdesaoSvgAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biRepository.ObterAdesaoSvgAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<XBiDashboard> ObterDashboardAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biRepository.ObterDashboardAsync(periodo, ano, secaoId, operadorId);
    }

    public async Task<XBiFiltros> ObterFiltrosAsync()
    {
      const string cacheKey = "BI:FILTROS";

      if (_cache.TryGetValue(cacheKey, out XBiFiltros cached))
        return cached;

      var datas = await _biRepository.ObterRangeDatasAsync();
      var filtros = new XBiFiltros
      {
        Anos = await _biRepository.ObterAnosAsync(),
        DataMax = datas.DataMax,
        DataMin = datas.DataMin,
        Operadores = await _biRepository.ObterOperadoresAsync()
      };

      _cache.Set(cacheKey, filtros, TimeSpan.FromHours(6));

      return filtros;
    }

    public Task<IEnumerable<XBiSerie>> ObterOperacoesAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biRepository.ObterOperacoesAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<IEnumerable<XBiSerie>> ObterParticipacaoOperadorAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biRepository.ObterOperacoesAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(string periodo, int? ano, int? secaoId)
    {
      return _biRepository.ObterTopOperadoresAsync(periodo, ano, secaoId);
    }
  }
}
