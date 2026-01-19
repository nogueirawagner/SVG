using SVG.App.Interfaces;
using SVG.Domain.Entities;
using SVG.Domain.Entities.Identity;
using SVG.Domain.Interfaces.Services;

namespace SVG.App.Services
{
  public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
  {
    private readonly IUsuarioService _usuarioService;

    public UsuarioAppService(
      IUsuarioService usuarioService)
        : base(usuarioService)
    {
      _usuarioService = usuarioService;
    }

    public Task AlterarSenhaAsync(int pUsuarioId, string pSenhaAtual, string pNovaSenha)
    {
      return _usuarioService.AlterarSenhaAsync(pUsuarioId, pSenhaAtual, pNovaSenha);
    }

    public Task CriarSenhaAsync(int pUsuarioID, string pNovaSenha)
    {
      return _usuarioService.CriarSenhaAsync(pUsuarioID, pNovaSenha);
    }

    public Task CriarUsuarioAsync(Usuario usuario)
    {
      return _usuarioService.CriarUsuarioAsync(usuario);
    }

    public Task CriarUsuarioComSenhaAsync(Usuario usuario, string senha)
    {
      return _usuarioService.CriarUsuarioComSenhaAsync(usuario, senha);
    }

    public Task<Usuario?> ValidarLogin(string pLogin, string pSenha)
    {
      return _usuarioService.ValidarLogin(pLogin, pSenha);
    }
  }
}
