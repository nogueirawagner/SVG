using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperacao;
using SVG.Domain.TiposEstruturados.TiposOperador;

namespace SVG.Domain.Interfaces.Repositories
{
  public interface IOperacaoRepository : IRepositoryBase<Operacao>
  {
    IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas);
    void AlterarSVGOperador(int pOperadorId, bool pSvg);
    IEnumerable<XDetalhesOperacao> PegarDetalhesOperacao(int pOperacaoID);
    IEnumerable<XOperacoesRealizadas> PegarOperacoesRealizadas();
    IEnumerable<XOperacoesSVGAberto> PegarOperacoesSVGAberto();
    void InsereCandidatoSVG(int pOperacaoID, int pOperadorID);
    void RemoveCandidatoSVG(int pOperacaoID, int pOperadorID);
    IEnumerable<XCandidatosOperacaoSVG> PegaCandidatoSVG(int pOperacaoID);
    IEnumerable<XOperacoesRealizadas> ListarOperacoesPorOrdemServico(string pOrdemServico);
    IEnumerable<XOperadorSelecionado> PegarOperadoresOperacaoResumido(int pOperacaoID);
    IEnumerable<XEscalaPlantao> PegarEscalaPlantao(DateTime pDataReferencia);
  }
}
