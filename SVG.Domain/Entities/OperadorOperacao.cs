using System;

namespace SVG.Domain.Entities
{
  public class OperadorOperacao
  {
    public int ID { get; set; }
    public int OperacaoID { get; set; }
    public int OperadorID { get; set; }
    public bool SVG { get; set; }
    public int Equipe { get; set; }
    public int Funcao { get; set; }
    public int Viatura { get; set; }

    public virtual Operacao Operacao { get; set; }
    public virtual Operador Operador { get; set; }
  }
}
