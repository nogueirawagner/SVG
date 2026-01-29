using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SVG.App.Interface;
using SVG.App.Interfaces;
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

    [HttpGet("dashboard")]
    public IActionResult Dashboard()
    {
      return View();
    }

    [HttpGet("adesao-svg")]
    public async Task<IActionResult> AdesaoSvg([FromQuery] string? periodo)
    {
      try
      {
        var periodoNormalizado = NormalizarPeriodo(periodo);

        return periodoNormalizado switch
        {
          "mensal" => Ok(await _biAppService.ObterMensalAsync()),
          "bimestral" => Ok(await _biAppService.ObterBimestralAsync()),
          "trimestral" => Ok(await _biAppService.ObterTrimestralAsync()),
          "semestral" => Ok(await _biAppService.ObterSemestralAsync()),

          _ => BadRequest() // nunca cai aqui
        };
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
