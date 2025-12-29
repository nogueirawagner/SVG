using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.TiposOperacao;

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

    public IEnumerable<DetalhesOperacao> PegarDetalhesOperacao(int pOperacaoID)
    {
      return _operacaoRepository.PegarDetalhesOperacao(pOperacaoID);
    }

    public IEnumerable<OperacoesRealizadas> PegarOperacoesRealizadas()
    {
      return _operacaoRepository.PegarOperacoesRealizadas();
    }

    public IEnumerable<OperacoesSVGAberto> PegarOperacoesSVGAberto()
    {
      return _operacaoRepository.PegarOperacoesSVGAberto();
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
