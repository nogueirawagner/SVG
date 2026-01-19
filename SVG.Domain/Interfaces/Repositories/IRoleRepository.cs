using SVG.Domain.Entities.Identity;
using SVG.Domain.TiposEstruturados.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Interfaces.Repositories
{
  public interface IRoleRepository : IRepositoryBase<Role>
  {
    XRole ObterPorNome(string pNome);
  }
}
