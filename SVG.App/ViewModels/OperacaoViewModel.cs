using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.App.ViewModels
{
  public class OperacaoViewModel
  {
    public int ID { get; set; }
    public DateTime DataHora { get; set; }
    public string Objeto { get; set; }
    public string DP { get; set; }
    public string Coordenador { get; set; }
    public int QtdEquipe { get; set; }
    public int TipoOperacaoID { get; set; }
  }
}
