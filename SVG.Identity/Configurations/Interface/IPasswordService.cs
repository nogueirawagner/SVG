using SVG.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Identity.Configurations.Interface
{
  public interface IPasswordService
  {
    string Hash(Usuario user, string senha);
    bool Verificar(Usuario user, string senha);
  }
}
