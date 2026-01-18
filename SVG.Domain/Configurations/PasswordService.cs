using Microsoft.AspNetCore.Identity;
using SVG.Domain.Configurations.Interface;
using SVG.Domain.Entities.Identity;

namespace SVG.Domain.Configurations
{
  public class PasswordService : IPasswordService
  {
    private readonly PasswordHasher<Usuario> _hasher = new();

    public string Hash(Usuario user, string senha)
        => _hasher.HashPassword(user, senha);

    public bool Verificar(Usuario user, string senha)
        => _hasher.VerifyHashedPassword(user, user.PasswordHash, senha)
           == PasswordVerificationResult.Success;
  }
}
