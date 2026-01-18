using SVG.Domain.Configurations.Interface;
using SVG.Domain.Entities.Identity;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Interfaces.Services
{
  public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
  {
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IPasswordService _passwordService;

    public UsuarioService(
      IUsuarioRepository usuarioRepository, 
      IPasswordService passwordService)
      : base(usuarioRepository)
    {
      _passwordService = passwordService;
      _usuarioRepository = usuarioRepository;
    }

    public Task<Usuario?> ValidarLogin(string pLogin, string pSenha)
    {
      return ValidarLogin(pLogin, pSenha);
    }

    public Task CriarSenhaAsync(int pUsuarioID, string pNovaSenha)
    {
      return CriarSenhaAsync(pUsuarioID, pNovaSenha);
    }

    public async Task AlterarSenhaAsync(int pUsuarioId, string pSenhaAtual, string pNovaSenha)
    {
      var usuario = await _usuarioRepository.ObterPorIdAsync(pUsuarioId)
          ?? throw new Exception("Usuário não encontrado");

      if (!_passwordService.Verificar(usuario, pSenhaAtual))
        throw new Exception("Senha atual inválida");

      usuario.PasswordHash = _passwordService.Hash(usuario, pNovaSenha);

      await _usuarioRepository.AtualizarAsync(usuario);
    }
  }
}
