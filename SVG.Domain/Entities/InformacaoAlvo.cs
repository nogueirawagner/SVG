namespace SVG.Domain.Entities;

public class InformacaoAlvo
{
    public int ID { get; set; }
    public int AlvoID { get; set; }
    public string Texto { get; set; } = "";
    public string? Fonte { get; set; }
    public DateTime DataHoraCriacao { get; set; }
    public virtual Alvo Alvo { get; set; } = null!;
}
