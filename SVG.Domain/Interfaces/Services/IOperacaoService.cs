using SVG.Domain.Entities;

namespace SVG.Domain.Interfaces.Services
{
  public interface IOperacaoService : IServiceBase<Operacao>
  {
    IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas);
  }
}
