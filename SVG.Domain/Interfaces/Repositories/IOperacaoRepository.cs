using SVG.Domain.Entities;

namespace SVG.Domain.Interfaces.Repositories
{
  public interface IOperacaoRepository : IRepositoryBase<Operacao>
  {
    IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas);
  }
}
