using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.BI
{
  public class XTopOperador
  {
    public int OperadorId { get; set; }
    public string Operador { get; set; } = "";
    public int TotalParticipacoes { get; set; }
    public string Sessao { get; set; }
    public string Matricula { get; set; }

  }
}
