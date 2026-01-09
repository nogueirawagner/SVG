using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Entities
{
  public class CalendarioPlantao
  {
    public int ID { get; set; }
    public int SecaoID { get; set; }
    public DateTime UltimoPlantao { get; set; }

    public virtual Sessao Secao { get; set; }
  }
}
