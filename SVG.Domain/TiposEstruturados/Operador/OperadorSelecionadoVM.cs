using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.Operador
{
  public class OperadorSelecionadoVM
  {
    public int OperadorID { get; set; }
    public bool SVG { get; set; } // true = voluntário, false = sessão
  }
}
