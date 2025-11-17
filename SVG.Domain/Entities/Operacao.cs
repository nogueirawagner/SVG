using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Entities
{
  public class Operacao
  {
    public int ID { get; set; }
    public DateTime DataHora { get; set; }
    public string Objeto { get; set; }
    public string DP { get; set; }
    public string Coordenador { get; set; }
    public int QtdEquipe { get; set; }

    public virtual ICollection<OperadorOperacao> OperadoresOperacao { get; set; }
    public virtual ICollection<ViaturaOperacao> ViaturasOperacao { get; set; }

    public Operacao()
    {
      OperadoresOperacao = new List<OperadorOperacao>();
      ViaturasOperacao = new List<ViaturaOperacao>();
    }
  }
}
