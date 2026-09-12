using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.Enums;

namespace SVG.Domain.TiposEstruturados.TiposViatura
{
  public class XViaturaMovimentacao
  {
    public int ID { get; set; }

    public int ViaturaID { get; set; }
    public virtual Viatura Viatura { get; set; }

    public int OperadorID { get; set; }
    public virtual Operador Operador { get; set; }

    public XFinalidadeViatura Finalidade { get; set; }

    public DateTime DataHoraRetirada { get; set; }
    public DateTime? DataHoraDevolucao { get; set; }

    public int KmInicial { get; set; }
    public int? KmFinal { get; set; }

    public string Observacao { get; set; }
  }
}
