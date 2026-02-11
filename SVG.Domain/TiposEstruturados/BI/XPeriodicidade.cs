using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.BI
{
  public class XPeriodicidade
  {
    public string Periodo { get; set; } = "mensal";

    public int? Ano { get; set; }
    public int? Mes { get; set; }

    public int? SecaoId { get; set; }
    public int? OperadorId { get; set; }
  }

}
