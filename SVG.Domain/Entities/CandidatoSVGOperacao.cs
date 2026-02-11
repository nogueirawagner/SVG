using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Entities
{
  public class CandidatoSVGOperacao
  {
    public int ID { get; set; }
    public int OperadorID { get; set; }
    public int OperacaoID { get; set; }
    public DateTime DataHoraCriacao { get; set; }

    public virtual Operacao Operacao { get; set; }
    public virtual Operador Operador { get; set; }
  }
}
