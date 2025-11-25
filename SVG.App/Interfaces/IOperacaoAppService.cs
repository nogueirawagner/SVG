using SVG.Domain.Entities;

namespace SVG.App.Interface
{
  public interface IOperacaoAppService : IAppServiceBase<Operacao>
  {
    IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas);
  }
}
