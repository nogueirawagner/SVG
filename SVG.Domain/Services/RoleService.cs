using SVG.Domain.Configurations.Interface;
using SVG.Domain.Entities.Identity;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Services
{
  public class RoleService : ServiceBase<Role>, IRoleService
  {
    private readonly IRoleRepository _roleRepository;

    public RoleService(IRoleRepository roleRepository)
      : base(roleRepository)
    {
      _roleRepository = roleRepository;
    }

    public XRole ObterPorNome(string pNome)
    {
      return _roleRepository.ObterPorNome(pNome);
    }
  }
}
