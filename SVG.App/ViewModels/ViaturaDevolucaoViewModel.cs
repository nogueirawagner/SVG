using SVG.Domain.TiposEstruturados.Enums;

namespace SVG.WebApp.Models
{
  public class ViaturaDevolucaoViewModel
  {
    public int ViaturaID { get; set; }

    public string? Prefixo { get; set; }

    public string? Placa { get; set; }

    public string? Modelo { get; set; }

    public int OperadorID { get; set; }

    public string? OperadorNome { get; set; }

    public int? KmFinal { get; set; }

    public int? KmProximaRevisao { get; set; }

    public int KmAtual { get; set; }

    public bool Abastecimento { get; set; }

    public int? KmAbastecimento { get; set; }
  }
}