using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Operacao;

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

    public IEnumerable<DetalhesOperacao> PegarDetalhesOperacao(int pOperacaoID)
    {
      return _operacaoRepository.PegarDetalhesOperacao(pOperacaoID);
    }

    public IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas)
    {
      return _operacaoRepository.PegarOperadoresSVG(pOperadorIDs, pDataLimite, pQtdVagas);  
    }
  }
}
