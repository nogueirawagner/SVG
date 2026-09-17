using SVG.Domain.Entities;

namespace SVG.App.Interface
{
  public interface IViaturaAppService : IAppServiceBase<Viatura>
  {
    IEnumerable<Viatura> PegarPorSecao(int pSecaoID);

    IEnumerable<Viatura> PegarDisponiveis();
    IEnumerable<Viatura> PegarViaturas();
  }
}
