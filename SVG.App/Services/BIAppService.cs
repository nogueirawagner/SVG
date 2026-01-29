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
    ): base(operacaoService)
    {
      _biService = biService;
      _operacaoService = operacaoService;
    }

    public Task<IEnumerable<XAdesaoSvg>> ObterBimestralAsync()
    {
      return _biService.ObterBimestralAsync();
    }

    public Task<IEnumerable<XAdesaoSvg>> ObterMensalAsync()
    {
       return _biService.ObterMensalAsync();
    }

    public Task<IEnumerable<XOperacaoBi>> ObterOperacoesPeriodo(string periodo)
    {
      return _biService.ObterOperacoesPeriodo(periodo);
    }

    public Task<IEnumerable<XParticipacaoOperador>> ObterParticipacaoOperadorPeriodo(string periodo)
    {
      return _biService.ObterParticipacaoOperadorPeriodo(periodo);  
    }

    public Task<IEnumerable<XAdesaoSvg>> ObterSemestralAsync()
    {
      return _biService.ObterSemestralAsync();
    }

    public Task<IEnumerable<XAdesaoSvg>> ObterTrimestralAsync()
    {
      return _biService.ObterTrimestralAsync();
    }
  }
}
