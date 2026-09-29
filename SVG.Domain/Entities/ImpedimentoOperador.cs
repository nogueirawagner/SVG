using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperador;

namespace SVG.Domain.Entities
{
  public class ImpedimentoOperador
  {
    public int ID { get; set; }

    public int OperadorID { get; set; }

    public XTipoImpedimentoOperador TipoImpedimento { get; set; }

    public DateTime DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public string Observacao { get; set; }

    public DateTime DataHoraCriacao { get; set; }

    public virtual Operador Operador { get; set; }
  }
}

