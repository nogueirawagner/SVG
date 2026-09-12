using SVG.Domain.Entities;

namespace SVG.Domain.Interfaces.Repositories
{
  public interface IViaturaRepository : IRepositoryBase<Viatura>
  {
    IEnumerable<Viatura> PegarPorSecao(int pSecaoID);

    IEnumerable<Viatura> PegarDisponiveis();
  }
}
