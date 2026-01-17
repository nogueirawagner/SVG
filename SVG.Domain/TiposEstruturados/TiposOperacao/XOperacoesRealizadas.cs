using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.TiposOperacao
{
  public class XOperacoesRealizadas
  {
    public int ID { get; set; }
    public DateTime DataHoraCriacao { get; set; }
    public DateTime DataHora { get; set; }
    public DateTime DataHoraInicio { get; set; }
    public DateTime? DataHoraFim { get; set; }
    public string Objeto { get; set; }
    public string OrdemServico { get; set; }
    public string Coordenador { get; set; }
    public string TipoOperacao { get; set; }
    public bool SvgAberto { get; set; }
    public int QtdVagasRestantes { get; set; }
    [NotMapped]
    public DateTime? DataHoraEncerramentoSVG { get; set; }
    public int QtdOperadores { get; set; }
  }
}
