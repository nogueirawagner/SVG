using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.BI
{
  public class XParticipacaoOperador
  {
    public DateTime DataSK { get; set; }
    public int TotalOperadores { get; set; }
    public decimal MediaOperadoresPorOperacao { get; set; }
  }
}
