using SVG.App.Interface;
using SVG.Domain.Entities.Identity;
using SVG.Domain.TiposEstruturados.Auth;

namespace SVG.App.Interfaces
{
  public interface IRoleAppService : IAppServiceBase<Role>
  {
    XRole ObterPorNome(string pNome);
  }
}
