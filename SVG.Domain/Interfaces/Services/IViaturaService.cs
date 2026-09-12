using SVG.Domain.Entities;

namespace SVG.Domain.Interfaces.Services
{
  public interface IViaturaService : IServiceBase<Viatura>
  {
    IEnumerable<Viatura> PegarPorSecao(int pSecaoID);

    IEnumerable<Viatura> PegarDisponiveis();
  }
}
