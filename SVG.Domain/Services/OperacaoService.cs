using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.TiposOperacao;
using SVG.Domain.TiposEstruturados.TiposOperador;

namespace SVG.Domain.Services
{
  public class OperacaoService : ServiceBase<Operacao>, IOperacaoService
  {
    private readonly IOperacaoRepository _operacaoRepository;

    public OperacaoService(IOperacaoRepository operacaoRepository)
      : base(operacaoRepository)
    {
      _operacaoRepository = operacaoRepository;
    }

    public void AlterarSVGOperador(int pOperadorId, bool pSvg)
    {
      _operacaoRepository.AlterarSVGOperador(pOperadorId, pSvg);
    }

    public void InsereCandidatoSVG(int pOperacaoID, int pOperadorID)
    {
      _operacaoRepository.InsereCandidatoSVG(pOperacaoID, pOperadorID);
    }

    public IEnumerable<XOperacoesRealizadas> ListarOperacoesPorOrdemServico(string pOrdemServico)
    {
      return _operacaoRepository.ListarOperacoesPorOrdemServico(pOrdemServico);
    }

    public IEnumerable<XCandidatosOperacaoSVG> PegaCandidatoSVG(int pOperacaoID)
    {
      return _operacaoRepository.PegaCandidatoSVG(pOperacaoID);
    }

    public IEnumerable<XDetalhesOperacao> PegarDetalhesOperacao(int pOperacaoID)
    {
      return _operacaoRepository.PegarDetalhesOperacao(pOperacaoID);
    }

    public IEnumerable<XEscalaPlantao> PegarEscalaPlantao(DateTime pDataReferencia)
    {
      return _operacaoRepository.PegarEscalaPlantao(pDataReferencia);
    }

    public IEnumerable<XOperacoesRealizadas> PegarOperacoesRealizadas()
    {
      return _operacaoRepository.PegarOperacoesRealizadas();
    }

    public IEnumerable<XOperacoesSVGAberto> PegarOperacoesSVGAberto()
    {
      return _operacaoRepository.PegarOperacoesSVGAberto();
    }

    public IEnumerable<XOperacoesSVGAberto> PegarOperacoesSVGAbertoOperador(int pOperadorID)
    {
      return _operacaoRepository.PegarOperacoesSVGAbertoOperador(pOperadorID);
    }

    public IEnumerable<XOperadorSelecionado> PegarOperadoresOperacaoResumido(int pOperacaoID)
    {
      return _operacaoRepository.PegarOperadoresOperacaoResumido(pOperacaoID);
    }

    public IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas)
    {
      return _operacaoRepository.PegarOperadoresSVG(pOperadorIDs, pDataLimite, pQtdVagas);  
    }

    public void RemoveCandidatoSVG(int pOperacaoID, int pOperadorID)
    {
      _operacaoRepository.RemoveCandidatoSVG(pOperacaoID, pOperadorID);
    }
  }
}
