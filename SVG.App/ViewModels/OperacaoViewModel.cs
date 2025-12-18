using System;
using System.ComponentModel.DataAnnotations;
using SVG.Domain.TiposEstruturados.TiposOperador;

namespace SVG.App.ViewModels
{
  public class OperacaoViewModel
  {
    public int ID { get; set; }

    [Required(ErrorMessage = "Informe a data e hora da operação.")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
    public DateTime DataHora { get; set; }

    [Required(ErrorMessage = "Informe o local da operação.")]
    public string Objeto { get; set; }

    [Required(ErrorMessage = "Informe apenas o número da OS.")]
    public string OrdemServico { get; set; }

    public string Coordenador { get; set; }

    [Required(ErrorMessage = "Selecione o coordenador.")]
    public int CoordenadorOperadorID { get; set; }

    [Required(ErrorMessage = "Informe a quantidade de vagas SVG.")]
    public int QtdVagasVoluntarios { get; set; }

    [Required(ErrorMessage = "Selecione o tipo de operação.")]
    public int TipoOperacaoID { get; set; }

    public int QtdVagasRestantes { get; set; }

    public string TipoOperacaoNome { get; set; }

    public bool SvgAberto { get; set; }

    // lista de operadores selecionados (IDs)
#warning trocar esse objeto por OperadorViewModel.
    public List<OperadorSelecionadoVM> OperadoresSelecionados { get; set; }
        = new List<OperadorSelecionadoVM>();
  }
}
