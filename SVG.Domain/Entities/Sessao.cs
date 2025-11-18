namespace SVG.Domain.Entities
{
  public class Sessao
  {
    public int ID { get; set; }
    public string Nome { get; set; }

    // Navegação reversa (opcional mas recomendado)
    public virtual ICollection<Operador> Operadores { get; set; }
    public virtual ICollection<Viatura> Viaturas { get; set; }

    public Sessao()
    {
      Operadores = new List<Operador>();
      Viaturas = new List<Viatura>();
    }
  }
}
