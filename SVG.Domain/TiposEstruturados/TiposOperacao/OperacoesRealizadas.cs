using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.TiposOperacao
{
  public class OperacoesRealizadas
  {
    public int ID { get; set; }
    public DateTime DataHoraCriacao { get; set; }
    public DateTime DataHora { get; set; }
    public string Objeto { get; set; }
    public string OrdemServico { get; set; }
    public string Coordenador { get; set; }
    public string TipoOperacao { get; set; }
  }
}
