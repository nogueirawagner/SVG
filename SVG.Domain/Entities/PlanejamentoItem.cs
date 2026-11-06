namespace SVG.Domain.Entities;

// Registros repetitivos do planejamento, nunca listas serializadas em um campo.
public class PlanejamentoItem
{
    public int ID { get; set; }
    public int PlanejamentoID { get; set; }
    public string Tipo { get; set; } = "Horario"; // Horario, Rota, Localizacao, Mandado, Providencia
    public string Descricao { get; set; } = "";
    public DateTime? DataHora { get; set; }
    public string? Responsavel { get; set; }
    public string? Url { get; set; }
    public decimal? DistanciaKm { get; set; }
    public int? DuracaoMinutos { get; set; }
    public virtual Planejamento Planejamento { get; set; } = null!;
}
