using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.BI
{
  public class XBiResultado
  {
    public List<XBiSerie> Serie { get; set; } = new();
    public XBiMetricas Metricas { get; set; } = new();
  }
}
