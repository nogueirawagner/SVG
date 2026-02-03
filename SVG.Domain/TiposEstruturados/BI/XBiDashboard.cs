using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.BI
{
  public class XBiDashboard
  {
    public int TotalOperacoes { get; set; }
    public int TotalOperadores { get; set; }
    public int TotalSvg { get; set; }
    public decimal PercentualSvg { get; set; }
  }

}
