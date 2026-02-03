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

    public Task<IEnumerable<XBiSerie>> ObterAdesaoSvgAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biService.ObterAdesaoSvgAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<XBiDashboard> ObterDashboardAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biService.ObterDashboardAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<IEnumerable<XBiSerie>> ObterOperacoesAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biService.ObterOperacoesAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<IEnumerable<XBiSerie>> ObterParticipacaoOperadorAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biService.ObterParticipacaoOperadorAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(string periodo, int? ano, int? secaoId)
    {
      return _biService.ObterTopOperadoresAsync(periodo, ano, secaoId);
    }
  }
}
