using SVG.Domain.TiposEstruturados.Enums;
using SVG.Domain.TiposEstruturados.TiposOperador;
using System.ComponentModel.DataAnnotations;

namespace SVG.App.ViewModels
{
  public class ImpedimentoOperadorViewModel
  {
    public int ID { get; set; }

    [Required(ErrorMessage = "Selecione um operador.")]
    [Display(Name = "Operador")]
    public int OperadorID { get; set; }

    [Required(ErrorMessage = "Selecione o tipo de impedimento.")]
    [Display(Name = "Tipo de impedimento")]
    public XTipoImpedimentoOperador? TipoImpedimento { get; set; }

    [Required(ErrorMessage = "Informe a data inicial.")]
    [DataType(DataType.Date)]
    [Display(Name = "Data inicial")]
    public DateTime DataInicio { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data final")]
    public DateTime? DataFim { get; set; }

    [Display(Name = "Observação")]
    [StringLength(
      500,
      ErrorMessage = "A observação deve possuir no máximo 500 caracteres.")]
    public string? Observacao { get; set; }

    [Display(Name = "Data de criação")]
    public DateTime DataHoraCriacao { get; set; }


    // ============================================================
    // PROPRIEDADES AUXILIARES PARA EXIBIÇÃO
    // ============================================================

    public string? OperadorNome { get; set; }

    public string? SessaoNome { get; set; }
  }
}