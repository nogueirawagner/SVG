using SVG.Domain.Entities.Identity;
using SVG.Domain.Services;
using SVG.Domain.TiposEstruturados.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Interfaces.Services
{
  public interface IRoleService : IServiceBase<Role>
  {
    XRole ObterPorNome(string pNome);
  }
}
