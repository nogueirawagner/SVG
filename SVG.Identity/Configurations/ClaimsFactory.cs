using Microsoft.AspNetCore.Authentication;
using SVG.Domain.Entities.Identity;
using SVG.Identity.Configurations.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Identity.Configurations
{
  public class ClaimsFactory : IClaimsFactory
  {
    public ClaimsPrincipal CriarPrincipal(Usuario usuario)
    {
      var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
        new Claim(ClaimTypes.Name, usuario.Login),
        new Claim("Nome", usuario.Nome)
    };

      foreach (var role in usuario.Roles)
        claims.Add(new Claim(ClaimTypes.Role, role.Role.Nome));

      return new ClaimsPrincipal(
          new ClaimsIdentity(claims, "Cookies")
      );
    }
  }
}
