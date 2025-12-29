using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.TiposOperacao
{
  public class OperacoesSVGAberto
  {
    public int ID { get; set; }
    public DateTime DataHoraCriacao { get; set; }
    public DateTime DataHora { get; set; }
    public DateTime? DataHoraFim { get; set; }
    public string TipoOperacao { get; set; }
    public int QtdVagasRestantes { get; set; }
  }
}
