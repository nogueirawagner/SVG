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

    public Task<IEnumerable<XBiSerie>> ObterAdesaoSvgAsync(XPeriodicidade periodicidade)
    {
      return _biRepository.ObterAdesaoSvgAsync(periodicidade);
    }

    public Task<XBiDashboard> ObterDashboardAsync(XPeriodicidade periodicidade)
    {
      return _biRepository.ObterDashboardAsync(periodicidade);
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

    public Task<IEnumerable<XBiSerie>> ObterOperacoesAsync(XPeriodicidade periodicidade)
    {
      return _biRepository.ObterOperacoesAsync(periodicidade);
    }

    public Task<IEnumerable<XBiSerie>> ObterParticipacaoOperadorAsync(XPeriodicidade periodicidade)
    {
      return _biRepository.ObterOperacoesAsync(periodicidade);
    }

    public Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(XPeriodicidade periodicidade)
    {
      return _biRepository.ObterTopOperadoresAsync(periodicidade);
    }
  }
}
