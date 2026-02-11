using Microsoft.Extensions.Caching.Memory;
using SVG.App.Interfaces;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.BI;
using System.Text.RegularExpressions;

namespace SVG.App.Services
{
  public class BIAppService : AppServiceBase<Operacao>, IBIAppService
  {
    private readonly IOperacaoService _operacaoService;
    private readonly IBIService _biService;

    public BIAppService(
      IBIService biService,
      IOperacaoService operacaoService
    ) : base(operacaoService)
    {
      _biService = biService;
      _operacaoService = operacaoService;
    }

    public Task<IEnumerable<XBiSerie>> ObterAdesaoSvgAsync(XPeriodicidade periodicidade)
    {
      return _biService.ObterAdesaoSvgAsync(periodicidade);
    }

    public Task<XBiDashboard> ObterDashboardAsync(XPeriodicidade periodicidade)
    {
      return _biService.ObterDashboardAsync(periodicidade);
    }

    public Task<IEnumerable<XBiSerie>> ObterOperacoesAsync(XPeriodicidade periodicidade)
    {
      return _biService.ObterOperacoesAsync(periodicidade);
    }

    public Task<IEnumerable<XBiSerie>> ObterParticipacaoOperadorAsync(XPeriodicidade periodicidade)
    {
      return _biService.ObterParticipacaoOperadorAsync(periodicidade);
    }

    public Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(XPeriodicidade periodicidade)
    {
      return _biService.ObterTopOperadoresAsync(periodicidade);
    }

    public Task<XBiFiltros> ObterFiltrosAsync()
    {
      return _biService.ObterFiltrosAsync();
    }
  }
}
