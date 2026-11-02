using System.ComponentModel.DataAnnotations;
using SVG.Domain.TiposEstruturados.Enums;

namespace SVG.WebApp.Models
{
  public class ViaturaEdicaoViewModel
  {
    public int ViaturaID { get; set; }

    [Display(Name = "Prefixo")]
    [StringLength(100)]
    public string? Prefixo { get; set; }

    [Display(Name = "Placa")]
    [StringLength(10)]
    public string? Placa { get; set; }

    [Display(Name = "Placa oficial")]
    [StringLength(10)]
    public string? PlacaOficial { get; set; }

    [Display(Name = "Marca")]
    [Required(ErrorMessage = "Informe a marca.")]
    [StringLength(100)]
    public string Marca { get; set; } = string.Empty;

    [Display(Name = "Modelo")]
    [Required(ErrorMessage = "Informe o modelo.")]
    [StringLength(100)]
    public string Modelo { get; set; } = string.Empty;

    [Display(Name = "Ano")]
    [Range(1900, 9999, ErrorMessage = "Informe um ano válido.")]
    public int? Ano { get; set; }

    [Display(Name = "Chassi")]
    [StringLength(17)]
    public string? Chassi { get; set; }

    [Display(Name = "Seção")]
    [Range(1, int.MaxValue, ErrorMessage = "Selecione uma seção.")]
    public int SessaoID { get; set; }

    [Display(Name = "Responsável pela viatura")]
    public int? OperadorResponsavelID { get; set; }

    [Display(Name = "Tipo")]
    [EnumDataType(typeof(XTipoCaracterizacaoViatura), ErrorMessage = "Selecione um tipo válido.")]
    public XTipoCaracterizacaoViatura TipoCaracterizacao { get; set; }

    [Display(Name = "KM atual")]
    [Range(0, int.MaxValue, ErrorMessage = "O KM não pode ser negativo.")]
    public int KmAtual { get; set; }

    [Display(Name = "KM do último abastecimento")]
    [Range(0, int.MaxValue, ErrorMessage = "O KM não pode ser negativo.")]
    public int? KmUltimoAbastecimento { get; set; }

    [Display(Name = "KM da próxima revisão")]
    [Range(0, int.MaxValue, ErrorMessage = "O KM não pode ser negativo.")]
    public int? KmProximaRevisao { get; set; }
  }
}
