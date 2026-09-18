using SVG.Domain.TiposEstruturados.Enums;

namespace SVG.WebApp.Models
{
  public class ViaturaRetiradaViewModel
  {
    public int ViaturaID { get; set; }

    public string? Prefixo { get; set; }

    public string? Placa { get; set; }

    public string? Modelo { get; set; }

    public string? Secao { get; set; }

    public int KmAtual { get; set; }

    public int? KmProximaRevisao { get; set; }

    public int OperadorID { get; set; }

    public string? OperadorNome { get; set; }

    public XFinalidadeViatura Finalidade { get; set; }

    public string? Observacao { get; set; }
  }
}