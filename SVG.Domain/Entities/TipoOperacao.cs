using SVG.Domain.Entities;

public class TipoOperacao
{
  public int ID { get; set; }
  public string Nome { get; set; }
  public int Peso { get; set; }

  public virtual ICollection<Operacao> Operacoes { get; set; }

  public TipoOperacao()
  {
    Operacoes = new List<Operacao>();
  }
}
