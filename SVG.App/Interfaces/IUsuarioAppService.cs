using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Entities.Identity;

namespace SVG.App.Interfaces
{
  public interface IUsuarioAppService : IAppServiceBase<Usuario>
  {
    Task<Usuario?> ValidarLogin(string pLogin, string pSenha);
    Task CriarSenhaAsync(int pUsuarioID, string pNovaSenha);
    Task AlterarSenhaAsync(int pUsuarioId, string pSenhaAtual, string pNovaSenha);
    Task CriarUsuarioAsync(Usuario usuario);
    Task CriarUsuarioComSenhaAsync(Usuario operador, string senha);
  }
}
