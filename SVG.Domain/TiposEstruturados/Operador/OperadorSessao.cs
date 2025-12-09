using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVG.Domain.Entities;

namespace SVG.Domain.TiposEstruturados.Operador
{
  public class OperadorSessao
  {
    public int SessaoID { get; set; }
    public int NomeSessao { get; set; }
    public List<OperadorSelecionadoVM> OperadoresSelecionados { get; set; }
        = new List<OperadorSelecionadoVM>();
  }
}
