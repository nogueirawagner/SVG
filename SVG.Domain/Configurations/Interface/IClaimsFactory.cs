using SVG.Domain.Entities.Identity;
using System.Security.Claims;

namespace SVG.Domain.Configurations.Interface
{
  public interface IClaimsFactory
  {
    ClaimsPrincipal CriarPrincipal(Usuario usuario);
  }
}
