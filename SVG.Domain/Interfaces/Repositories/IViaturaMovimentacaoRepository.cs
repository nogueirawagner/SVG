using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;

namespace SVG.Domain.Interfaces.Repositories 
{
  public interface IViaturaMovimentacaoRepository
      : IRepositoryBase<ViaturaMovimentacao>
  {
    IEnumerable<ViaturaMovimentacao> PegarPorViatura(int pViaturaID);

    ViaturaMovimentacao PegarUltimaMovimentacao(int pViaturaID);
  }
}