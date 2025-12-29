using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperacao;

namespace SVG.Domain.Interfaces.Repositories
{
  public interface IOperacaoRepository : IRepositoryBase<Operacao>
  {
    IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas);
    void AlterarSVGOperador(int pOperadorId, bool pSvg);
    IEnumerable<DetalhesOperacao> PegarDetalhesOperacao(int pOperacaoID);
    IEnumerable<OperacoesRealizadas> PegarOperacoesRealizadas();
    IEnumerable<OperacoesSVGAberto> PegarOperacoesSVGAberto();
    void InsereCandidatoSVG(int pOperacaoID, int pOperadorID);
    void RemoveCandidatoSVG(int pOperacaoID, int pOperadorID);
  }
}
