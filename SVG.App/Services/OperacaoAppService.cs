using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.TiposOperacao;

namespace SVG.App.Services
{
  public class OperacaoAppService : AppServiceBase<Operacao>, IOperacaoAppService
  {
    private readonly IOperacaoService _operacaoService;

    public OperacaoAppService(IOperacaoService operacaoService)
      : base(operacaoService)
    {
      _operacaoService = operacaoService;
    }

    public void AlterarSVGOperador(int pOperadorId, bool pSvg)
    {
      _operacaoService.AlterarSVGOperador(pOperadorId, pSvg);
    }

    public void InsereCandidatoSVG(int pOperacaoID, int pOperadorID)
    {
      _operacaoService.InsereCandidatoSVG(pOperacaoID, pOperadorID);
    }

    public IEnumerable<XOperacoesRealizadas> ListarOperacoesPorOrdemServico(string pOrdemServico)
    {
      return _operacaoService.ListarOperacoesPorOrdemServico(pOrdemServico);
    }

    public IEnumerable<XCandidatosOperacaoSVG> PegaCandidatoSVG(int pOperacaoID)
    {
      return _operacaoService.PegaCandidatoSVG(pOperacaoID);
    }

    public IEnumerable<XDetalhesOperacao> PegarDetalhesOperacao(int pOperacaoID)
    {
      return _operacaoService.PegarDetalhesOperacao(pOperacaoID); 
    }

    public IEnumerable<XOperacoesRealizadas> PegarOperacoesRealizadas()
    {
      return _operacaoService.PegarOperacoesRealizadas();
    }

    public IEnumerable<XOperacoesSVGAberto> PegarOperacoesSVGAberto()
    {
      return _operacaoService.PegarOperacoesSVGAberto();
    }

    public IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas)
    {
      return _operacaoService.PegarOperadoresSVG(pOperadorIDs, pDataLimite, pQtdVagas);
    }

    public void RemoveCandidatoSVG(int pOperacaoID, int pOperadorID)
    {
      _operacaoService.RemoveCandidatoSVG(pOperacaoID, pOperadorID);
    }
  }
}
