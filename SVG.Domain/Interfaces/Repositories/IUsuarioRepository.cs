using SVG.Domain.Entities.Identity;
using SVG.Domain.Interfaces.Repositories;

namespace SVG.Domain.Interfaces.Services
{

  public interface IUsuarioRepository : IRepositoryBase<Usuario>
  {
    Task<Usuario?> ObterPorIdAsync(int id);
    Task<Usuario?> ObterPorLoginAsync(string login);
    Task<IEnumerable<Usuario>> ListarAsync();
    Task AdicionarAsync(Usuario usuario);
    Task AtualizarAsync(Usuario usuario);
    Task RemoverAsync(int id);
    Task CriarUsuarioAsync(Usuario usuario);
  }
}
