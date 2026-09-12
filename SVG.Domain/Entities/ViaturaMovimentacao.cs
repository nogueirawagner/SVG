using SVG.Domain.TiposEstruturados.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Entities
{
  public class ViaturaMovimentacao
  {
    public int ID { get; set; }

    public int ViaturaID { get; set; }
    public virtual Viatura Viatura { get; set; }

    public int OperadorID { get; set; }
    public virtual Operador Operador { get; set; }

    public DateTime DataHora { get; set; }

    public XFinalidadeViatura Finalidade { get; set; }

    public XSituacaoViatura Situacao { get; set; }  

    public DateTime DataHoraRetirada { get; set; }
    public DateTime? DataHoraDevolucao { get; set; }

    public int KmInicial { get; set; }
    public int? KmFinal { get; set; }

    public string Observacao { get; set; }
  }
}
