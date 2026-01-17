using Microsoft.AspNetCore.Identity;
using SVG.Domain.Entities.Identity;
using SVG.Identity.Configurations.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Identity.Configurations
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
