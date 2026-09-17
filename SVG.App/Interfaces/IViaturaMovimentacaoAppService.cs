using SVG.Domain.Entities;

namespace SVG.App.Interface
{
  public interface IViaturaMovimentacaoAppService
    : IAppServiceBase<ViaturaMovimentacao>
  {
    IEnumerable<ViaturaMovimentacao> PegarPorViatura(int pViaturaID);

    ViaturaMovimentacao PegarUltimaMovimentacao(int pViaturaID);

    void RetirarViatura(
      ViaturaMovimentacao pMovimentacao,
      int pOperadorID);

    void DevolverViatura(
      int pViaturaID,
      int pOperadorID,
      int pKmFinal,
      bool pAbastecimento,
      int? pKmAbastecimento);
  }
}