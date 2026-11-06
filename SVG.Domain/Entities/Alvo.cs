namespace SVG.Domain.Entities;

public class Alvo
{
    public int ID { get; set; }
    public string Nome { get; set; } = "";
    public string? Alcunha { get; set; }
    public string? CPF { get; set; }
    public string? RG { get; set; }
    public DateTime? DataNascimento { get; set; }
    public string? NomeMae { get; set; }
    public string? NomePai { get; set; }
    public DateTime DataHoraCriacao { get; set; }
    public virtual ICollection<PlanejamentoAlvo> Planejamentos { get; set; } = new List<PlanejamentoAlvo>();
    public virtual ICollection<AnexoAlvo> Anexos { get; set; } = new List<AnexoAlvo>();
    public virtual ICollection<InformacaoAlvo> Informacoes { get; set; } = new List<InformacaoAlvo>();
}
