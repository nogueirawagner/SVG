namespace SVG.Domain.Entities;

public class PlanejamentoIntegrante
{
    public int ID { get; set; }
    public int PlanejamentoID { get; set; }
    public int OperadorID { get; set; }
    public int? ViaturaID { get; set; }
    public string? Entrada { get; set; }
    public string Funcao { get; set; } = "";
    public virtual Operador Operador { get; set; } = null!;
    public virtual Viatura? Viatura { get; set; }
    public virtual Planejamento Planejamento { get; set; } = null!;
}
