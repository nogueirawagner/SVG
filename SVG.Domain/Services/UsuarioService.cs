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
    private readonly IRoleRepository _roleRepository;
    private readonly IPasswordService _passwordService;

    public UsuarioService(
      IUsuarioRepository usuarioRepository,
      IPasswordService passwordService,
      IRoleRepository roleRepository)
      : base(usuarioRepository)
    {
      _passwordService = passwordService;
      _usuarioRepository = usuarioRepository;
      _roleRepository = roleRepository;
    }

    public async Task<Usuario?> ValidarLogin(string pLogin, string pSenha)
    {
      var usuario = await _usuarioRepository.ObterPorLoginAsync(pLogin);
      if (usuario == null || !usuario.Ativo)
        return null;

      if (!_passwordService.Verificar(usuario, pSenha))
        return null;

      GarantirRolePadrao(usuario); // 🔒 regra centralizada

      await _usuarioRepository.AtualizarAsync(usuario);

      return usuario;
    }

    public async Task CriarUsuarioAsync(Usuario usuario)
    {
      var existente = await _usuarioRepository.ObterPorLoginAsync(usuario.Login);
      if (existente != null)
        throw new Exception("Já existe um usuário com este login.");

      await _usuarioRepository.AdicionarAsync(usuario);
    }


    public async Task CriarSenhaAsync(int pUsuarioID, string pSenha)
    {
      var usuario = await _usuarioRepository.ObterPorIdAsync(pUsuarioID)
        ?? throw new Exception("Usuário não encontrado");

      usuario.PasswordHash = _passwordService.Hash(usuario, pSenha);

      GarantirRolePadrao(usuario);

      await _usuarioRepository.AtualizarAsync(usuario);
    }

    public async Task AlterarSenhaAsync(int pUsuarioId, string pSenhaAtual, string pNovaSenha)
    {
      var usuario = await _usuarioRepository.ObterPorIdAsync(pUsuarioId)
          ?? throw new Exception("Usuário não encontrado");

      if (!_passwordService.Verificar(usuario, pSenhaAtual))
        throw new Exception("Senha atual inválida");

      usuario.PasswordHash = _passwordService.Hash(usuario, pNovaSenha);

      GarantirRolePadrao(usuario);

      await _usuarioRepository.AtualizarAsync(usuario);
    }


    private void GarantirRolePadrao(Usuario usuario)
    {
      usuario.Roles.Clear();
      var role = new Role();

      if (usuario.Operador != null)
      {
        var roleResult = _roleRepository.ObterPorNome("Operador");

        if (roleResult != null)
        {
          role.ID = roleResult.ID;
          role.Nome = roleResult.Nome;


          usuario.Roles.Add(new UsuarioRole
          {
            Role = role
          }); 
        }
      }
      else
      {
        var roleResult = _roleRepository.ObterPorNome("Admin");

        if (roleResult != null)
        {
          role.ID = roleResult.ID;
          role.Nome = roleResult.Nome;

          usuario.Roles.Add(new UsuarioRole
          {
            Role = role
          });
        }
      }
    }
  }
}
