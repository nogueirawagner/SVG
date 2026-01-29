using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.BI
{
  public class XAdesaoSvg
  {
    public DateTime DataSK { get; set; }
    public int TotalOperacoes { get; set; }
    public int TotalOperadores { get; set; }
    public int TotalOperadoresSVG { get; set; }
    public decimal MediaOperadoresPorOperacao { get; set; }
    public decimal MediaSVGPorOperacao { get; set; }
  }

}
