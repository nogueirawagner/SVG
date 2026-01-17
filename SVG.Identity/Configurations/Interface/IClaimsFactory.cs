using SVG.Domain.Entities.Identity;
using System.Security.Claims;

namespace SVG.Identity.Configurations.Interface
{
  public interface IClaimsFactory
  {
    ClaimsPrincipal CriarPrincipal(Usuario usuario);
  }
}
