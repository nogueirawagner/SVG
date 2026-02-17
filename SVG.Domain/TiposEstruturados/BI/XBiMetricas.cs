using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.BI
{
  public class XBiMetricas
  {
    public int Total { get; set; }
    public double Media { get; set; }
    public int Maximo { get; set; }
    public int Minimo { get; set; }
    public double DesvioPadrao { get; set; }
    public double CrescimentoPercentual { get; set; }
    public int MelhorPeriodo { get; set; }
  }
}
