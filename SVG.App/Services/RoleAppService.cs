using SVG.App.Interfaces;
using SVG.Domain.Entities.Identity;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.App.Services
{
  public class RoleAppService : AppServiceBase<Role>, IRoleAppService
  {
    private readonly IRoleService _roleService;

    public RoleAppService(IRoleService roleService)
      : base(roleService)
    {
      _roleService = roleService;
    }

    public XRole ObterPorNome(string pNome)
    {
      return _roleService.ObterPorNome(pNome); 
    }
  }
}
