namespace SVG.Domain.Entities;
public class AnexoPlanejamento
{
    public int ID { get; set; }
    public int PlanejamentoID { get; set; }
    public string NomeArquivo { get; set; } = "";
    public string TipoMime { get; set; } = "";
    public string Caminho { get; set; } = "";
    public DateTime DataHoraCriacao { get; set; }
    public virtual Planejamento Planejamento { get; set; } = null!;
}
