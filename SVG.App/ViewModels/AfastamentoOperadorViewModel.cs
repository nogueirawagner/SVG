using SVG.Domain.TiposEstruturados.TiposOperador;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.App.ViewModels
{
  public class AfastamentoOperadorViewModel
  {
    public int ID { get; set; }

    [Required(ErrorMessage = "Selecione o operador.")]
    [Display(Name = "Operador")]
    public int OperadorID { get; set; }

    [Required(ErrorMessage = "Selecione o tipo de afastamento.")]
    [Display(Name = "Tipo de afastamento")]
    public XTipoAfastamento? TipoAfastamento { get; set; }

    [Required(ErrorMessage = "Informe a data inicial.")]
    [Display(Name = "Data inicial")]
    [DataType(DataType.Date)]
    public DateTime DataInicio { get; set; }

    [Required(ErrorMessage = "Informe a data final.")]
    [Display(Name = "Data final")]
    [DataType(DataType.Date)]
    public DateTime DataFim { get; set; }

    [Display(Name = "Observação")]
    [StringLength(500)]
    public string Observacao { get; set; }

    public DateTime DataHoraCriacao { get; set; }

    // Apresentação
    public string OperadorNome { get; set; }

    public string SessaoNome { get; set; }
  }
}
