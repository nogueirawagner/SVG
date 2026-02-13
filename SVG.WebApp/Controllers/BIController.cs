using Microsoft.AspNetCore.Mvc;
using SVG.App.Interfaces;
using SVG.Domain.TiposEstruturados.BI;

[Route("bi")]
public class BIController : Controller
{
  private readonly IBIAppService _biAppService;

  private static readonly string[] PeriodosValidos =
      { "diario", "mensal", "bimestral", "trimestral", "semestral" };

  public BIController(IBIAppService biAppService)
  {
    _biAppService = biAppService;
  }

  // =========================
  // VIEWS (HTML)
  // =========================

  [HttpGet("/bi")]
  public IActionResult Index()
      => View();

  [HttpGet("/bi/svg")]
  public IActionResult Svg()
      => View();

  [HttpGet("/bi/operacoes-view")]
  public IActionResult OperacoesView()
      => View();

  [HttpGet("/bi/operadores-view")]
  public IActionResult OperadoresView()
      => View();

  // =========================
  // API (JSON)
  // =========================

  [HttpGet("dashboard")]
  public async Task<ActionResult<XBiDashboard>> Dashboard(XPeriodicidade periodicidade)
  {
    periodicidade.Periodo = NormalizarPeriodo(periodicidade.Periodo);
    return Ok(await _biAppService.ObterDashboardAsync(periodicidade));
  }

  [HttpGet("adesao-svg")]
  public async Task<ActionResult<IEnumerable<XBiSerie>>> AdesaoSvg(XPeriodicidade periodicidade)
  {
    periodicidade.Periodo = NormalizarPeriodo(periodicidade.Periodo);
    return Ok(await _biAppService.ObterAdesaoSvgAsync(periodicidade));
  }

  [HttpGet("filtros")]
  public async Task<IActionResult> Filtros()
  {
    return Ok(await _biAppService.ObterFiltrosAsync());
  }

  [HttpGet("operacoes")]
  public async Task<ActionResult<IEnumerable<XBiSerie>>> Operacoes(XPeriodicidade periodicidade)
  {
    periodicidade.Periodo = NormalizarPeriodo(periodicidade.Periodo);
    return Ok(await _biAppService.ObterOperacoesAsync(periodicidade));
  }

  [HttpGet("operadores")]
  public async Task<ActionResult<IEnumerable<XBiSerie>>> Operadores(XPeriodicidade periodicidade)
  {
    periodicidade.Periodo = NormalizarPeriodo(periodicidade.Periodo);
    return Ok(await _biAppService.ObterParticipacaoOperadorAsync(periodicidade));
  }

  [HttpGet("top-operadores")]
  public async Task<ActionResult<IEnumerable<XTopOperador>>> TopOperadores(XPeriodicidade periodicidade)
  {
    periodicidade.Periodo = NormalizarPeriodo(periodicidade.Periodo);
    return Ok(await _biAppService.ObterTopOperadoresAsync(periodicidade));
  }

  // =========================
  // UTIL
  // =========================

  private string NormalizarPeriodo(string? periodo)
  {
    periodo = periodo?.ToLowerInvariant() ?? "mensal";

    if (!PeriodosValidos.Contains(periodo))
      throw new ArgumentException("Período inválido");

    return periodo;
  }
}
