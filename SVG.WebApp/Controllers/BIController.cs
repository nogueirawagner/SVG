using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SVG.App.Interface;
using SVG.App.Interfaces;
using SVG.App.Services;
using SVG.Domain.Configurations.Interface;
using SVG.WebApp.Configurations;
using System.Data.Entity.Infrastructure;

namespace SVG.WebApp.Controllers
{
  [Authorize(Roles = "Admin")]
  [Route("bi")]
  public class BIController : Controller
  {
    private readonly IClaimsFactory _claimsFactory;
    private readonly IUserContext _userContext;
    private readonly IBIAppService _biAppService;
    private static readonly string[] PeriodosValidos =
      { "mensal", "bimestral", "trimestral", "semestral" };

    public BIController(
      IClaimsFactory claimsFactory,
      IUserContext userContext,
      IBIAppService biAppService
      )
    {
      _claimsFactory = claimsFactory;
      _userContext = userContext;
      _biAppService = biAppService;
    }

    /*
      GET /api/bi/dashboard
      GET /api/bi/adesao-svg
      GET /api/bi/operacoes
      GET /api/bi/operadores
      GET /api/bi/top-operadores
     */


    public IActionResult Index()
        => View();

    public IActionResult Svg()
        => View();

    [HttpGet("operacoes")]
    public async Task<IActionResult> Operacoes(
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
    public async Task<IActionResult> Operadores(
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
    public async Task<IActionResult> TopOperadores(
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

    [HttpGet("dashboard")]
    public async Task<IActionResult> Dashboard(
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
    public async Task<IActionResult> AdesaoSvg(
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

    [HttpGet("operacoes")]
    public async Task<IActionResult> OperacoesPeriodo([FromQuery] string? periodo)
    {
      try
      {
        var periodoNormalizado = NormalizarPeriodo(periodo);
        return Ok(await _biAppService.ObterOperacoesPeriodo(periodoNormalizado));
      }
      catch (ArgumentException ex)
      {
        return BadRequest(new
        {
          erro = ex.Message,
          valoresAceitos = PeriodosValidos
        });
      }
    }

    [HttpGet("participacao-operador")]
    public async Task<IActionResult> ParticipacaoOperadorPeriodo([FromQuery] string? periodo)
    {
      try
      {
        var periodoNormalizado = NormalizarPeriodo(periodo);
        return Ok(await _biAppService.ObterParticipacaoOperadorPeriodo(periodoNormalizado));
      }
      catch (ArgumentException ex)
      {
        return BadRequest(new
        {
          erro = ex.Message,
          valoresAceitos = PeriodosValidos
        });
      }
    }

    private string NormalizarPeriodo(string periodo)
    {
      periodo = periodo?.ToLowerInvariant() ?? "mensal";

      if (!PeriodosValidos.Contains(periodo))
        throw new ArgumentException("Período inválido");

      return periodo;
    }
  }
}
