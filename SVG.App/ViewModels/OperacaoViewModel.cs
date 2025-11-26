using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SVG.Domain.TiposEstruturados.Operador;

namespace SVG.App.ViewModels
{
  public class OperacaoViewModel
  {
    public int ID { get; set; }

    [Required(ErrorMessage = "Informe a data e hora da operação.")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
    public DateTime DataHora { get; set; }

    [Required(ErrorMessage = "Informe o objeto da operação.")]
    public string Objeto { get; set; }

    [Required(ErrorMessage = "Informe a DP de apoio.")]
    public string DP { get; set; }

    // NÃO quero validar nem bindar esse campo.
    // Vou preenchê-lo manualmente a partir do coordenador selecionado.
    public string Coordenador { get; set; }

    [Required(ErrorMessage = "Selecione o coordenador.")]
    public int CoordenadorOperadorID { get; set; }

    [Required(ErrorMessage = "Informe a quantidade de equipes.")]
    public int QtdEquipe { get; set; }

    // Se puder ser vazio, deixe nullable; se quiser obrigatório, coloque [Required].
    public int QtdVagasVoluntarios { get; set; }

    [Required(ErrorMessage = "Selecione o tipo de operação.")]
    public int TipoOperacaoID { get; set; }

    public string TipoOperacaoNome { get; set; }

    // lista de operadores selecionados (IDs)
    public List<OperadorSelecionadoVM> OperadoresSelecionados { get; set; }
        = new List<OperadorSelecionadoVM>();
  }
}
