using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class ViaturaMovimentacaoAppService
    : AppServiceBase<ViaturaMovimentacao>, IViaturaMovimentacaoAppService
  {
    private readonly IViaturaMovimentacaoService _viaturaMovimentacaoService;

    public ViaturaMovimentacaoAppService(
      IViaturaMovimentacaoService pViaturaMovimentacaoService)
      : base(pViaturaMovimentacaoService)
    {
      _viaturaMovimentacaoService = pViaturaMovimentacaoService;
    }

    public IEnumerable<ViaturaMovimentacao> PegarPorViatura(int pViaturaID)
    {
      return _viaturaMovimentacaoService
        .PegarPorViatura(pViaturaID);
    }

    public ViaturaMovimentacao PegarUltimaMovimentacao(int pViaturaID)
    {
      return _viaturaMovimentacaoService
        .PegarUltimaMovimentacao(pViaturaID);
    }

    public void RetirarViatura(
      ViaturaMovimentacao pMovimentacao,
      int pOperadorID)
    {
      _viaturaMovimentacaoService
        .RetirarViatura(pMovimentacao, pOperadorID);
    }

    public void DevolverViatura(
      int pViaturaID,
      int pOperadorID)
    {
      _viaturaMovimentacaoService
        .DevolverViatura(pViaturaID, pOperadorID);
    }
  }
}