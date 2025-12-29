using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVG.Domain.Entities;

namespace SVG.Domain.TiposEstruturados.TiposOperador
{
  public class XOperadorSessao
  {
    public int SessaoID { get; set; }
    public int NomeSessao { get; set; }
    public List<Operador> OperadoresSelecionados { get; set; }
        = new List<Operador>();
  }
}
