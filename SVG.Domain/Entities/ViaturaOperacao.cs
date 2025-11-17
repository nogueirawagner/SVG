namespace SVG.Domain.Entities
{
  public class ViaturaOperacao
  {
    public int ID { get; set; }

    public int ViaturaID { get; set; }
    public int OperacaoID { get; set; }

    public virtual Viatura Viatura { get; set; }
    public virtual Operacao Operacao { get; set; }
  }
}
