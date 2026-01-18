using SVG.Domain.Entities.Identity;

namespace SVG.Domain.Interfaces.Services
{
  public interface IUsuarioService : IServiceBase<Usuario>
  {
    Task<Usuario?> ValidarLogin(string pLogin, string pSenha);
    Task CriarSenhaAsync(int pUsuarioID, string pNovaSenha);
    Task AlterarSenhaAsync(int pUsuarioId, string pSenhaAtual, string pNovaSenha);

  }
}
