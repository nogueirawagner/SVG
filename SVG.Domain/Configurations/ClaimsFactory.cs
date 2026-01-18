using SVG.Domain.Configurations.Interface;
using SVG.Domain.Entities.Identity;
using System.Security.Claims;

namespace SVG.Domain.Configurations
{
  public class ClaimsFactory : IClaimsFactory
  {
    public ClaimsPrincipal CriarPrincipal(Usuario usuario)
    {
      var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, usuario.ID.ToString()),
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
