using Microsoft.AspNetCore.Mvc;
using SVG.App.Interfaces;
using SVG.Domain.TiposEstruturados.BI;

[ApiController]
[Route("bi")]
public class BIController : Controller
{
  private readonly IBIAppService _biAppService;

  private static readonly string[] PeriodosValidos =
      { "mensal", "bimestral", "trimestral", "semestral" };

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
  public async Task<ActionResult<XBiDashboard>> Dashboard(
      int? ano,
      string periodo = "mensal",
      int? secaoId = null,
      int? operadorId = null)
  {
    return Ok(await _biAppService.ObterDashboardAsync(
        NormalizarPeriodo(periodo),
        ano,
        secaoId,
        operadorId
    ));
  }

  [HttpGet("adesao-svg")]
  public async Task<ActionResult<IEnumerable<XBiSerie>>> AdesaoSvg(
      int? ano,
      string periodo = "mensal",
      int? secaoId = null,
      int? operadorId = null)
  {
    return Ok(await _biAppService.ObterAdesaoSvgAsync(
        NormalizarPeriodo(periodo),
        ano,
        secaoId,
        operadorId
    ));
  }

  [HttpGet("filtros")]
  public async Task<IActionResult> Filtros()
  {
    return Ok(await _biAppService.ObterFiltrosAsync());
  }

  [HttpGet("operacoes")]
  public async Task<ActionResult<IEnumerable<XBiSerie>>> Operacoes(
      int? ano,
      string periodo = "mensal",
      int? secaoId = null,
      int? operadorId = null)
  {
    return Ok(await _biAppService.ObterOperacoesAsync(
        NormalizarPeriodo(periodo),
        ano,
        secaoId,
        operadorId
    ));
  }

  [HttpGet("operadores")]
  public async Task<ActionResult<IEnumerable<XBiSerie>>> Operadores(
      int? ano,
      string periodo = "mensal",
      int? secaoId = null,
      int? operadorId = null)
  {
    return Ok(await _biAppService.ObterParticipacaoOperadorAsync(
        NormalizarPeriodo(periodo),
        ano,
        secaoId,
        operadorId
    ));
  }

  [HttpGet("top-operadores")]
  public async Task<ActionResult<IEnumerable<XTopOperador>>> TopOperadores(
      int? ano,
      string periodo = "mensal",
      int? secaoId = null)
  {
    return Ok(await _biAppService.ObterTopOperadoresAsync(
        NormalizarPeriodo(periodo),
        ano,
        secaoId
    ));
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
