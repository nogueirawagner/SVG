using SVG.Domain.Entities;

namespace SVG.App.Interface
{
  public interface IViaturaMovimentacaoAppService
    : IAppServiceBase<ViaturaMovimentacao>
  {
    IEnumerable<ViaturaMovimentacao> PegarPorViatura(int pViaturaID);

    ViaturaMovimentacao PegarUltimaMovimentacao(int pViaturaID);

    ViaturaMovimentacao? PegarUltimaMovimentacaoViatura(int pViaturaID);

    void RetirarViatura(
      ViaturaMovimentacao pMovimentacao,
      int pOperadorID,
      int pOperadorResponsavelID);

    void DevolverViatura(
      int pViaturaID,
      int pOperadorID,
      int pKmFinal,
      bool pAbastecimento,
      int? pKmAbastecimento,
      DateTime pDataHoraDevolucao,
      int pNivelCombustivel,
      int pOperadorResponsavelID);
  }
}