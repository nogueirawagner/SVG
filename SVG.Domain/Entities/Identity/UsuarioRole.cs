using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Entities.Identity
{
  public class UsuarioRole
  {
    public int ID { get; set; }
    public int UsuarioID { get; set; }
    public Usuario? Usuario { get; set; }

    public int RoleID { get; set; }
    public Role? Role { get; set; }
  }

}
