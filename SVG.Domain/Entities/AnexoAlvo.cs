namespace SVG.Domain.Entities;

public class AnexoAlvo
{
    public int ID { get; set; }
    public int AlvoID { get; set; }
    public string NomeArquivo { get; set; } = "";
    public string TipoMime { get; set; } = "";
    public string Caminho { get; set; } = "";
    public DateTime DataHoraCriacao { get; set; }
    public bool FotoPrincipal { get; set; }
    public virtual Alvo Alvo { get; set; } = null!;
}
