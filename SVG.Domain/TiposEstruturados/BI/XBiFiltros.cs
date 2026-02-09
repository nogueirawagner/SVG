using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.BI
{
  public class XBiFiltros
  {
    public IEnumerable<int> Anos { get; set; } = [];
    public DateTime DataMin { get; set; }
    public DateTime DataMax { get; set; }
    public IEnumerable<XBiOperadorFiltro> Operadores { get; set; } = [];
  }
}
