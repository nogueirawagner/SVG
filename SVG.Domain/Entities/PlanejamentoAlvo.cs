namespace SVG.Domain.Entities;

public class PlanejamentoAlvo
{
    public int ID { get; set; }
    public int PlanejamentoID { get; set; }
    public int AlvoID { get; set; }
    public string? Codigo { get; set; }
    public string? Observacoes { get; set; }
    public virtual Planejamento Planejamento { get; set; } = null!;
    public virtual Alvo Alvo { get; set; } = null!;
}
