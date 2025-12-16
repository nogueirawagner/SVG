using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperacao;

namespace SVG.Domain.Interfaces.Services
{
  public interface IOperacaoService : IServiceBase<Operacao>
  {
    IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas);
    IEnumerable<DetalhesOperacao> PegarDetalhesOperacao(int pOperacaoID);
    void AlterarSVGOperador(int pOperadorId, bool pSvg);
    IEnumerable<OperacoesRealizadas> PegarOperacoesRealizadas();
  }
}
