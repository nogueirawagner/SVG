using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperacao;

namespace SVG.App.Interface
{
  public interface IOperacaoAppService : IAppServiceBase<Operacao>
  {
    IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas);
    IEnumerable<DetalhesOperacao> PegarDetalhesOperacao(int pOperacaoID);
    void AlterarSVGOperador(int pOperadorId, bool pSvg);
  }
}
