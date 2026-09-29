using Microsoft.AspNetCore.Mvc.Rendering;
using SVG.Domain.TiposEstruturados.Enums;

namespace SVG.App.ViewModels
{
  public class ImpedimentoOperadorListarViewModel
  {
    // ============================================================
    // DADOS DA TABELA
    // ============================================================

    public IEnumerable<ImpedimentoOperadorViewModel> Impedimentos
    {
      get;
      set;
    } = new List<ImpedimentoOperadorViewModel>();


    // ============================================================
    // ANO
    // ÚNICO FILTRO PROCESSADO NO SERVIDOR
    // ============================================================

    public int Ano { get; set; }


    // ============================================================
    // LISTAS UTILIZADAS PELOS FILTROS CLIENT-SIDE
    // ============================================================

    public IEnumerable<SelectListItem> Operadores
    {
      get;
      set;
    } = new List<SelectListItem>();

    public IEnumerable<SelectListItem> Sessoes
    {
      get;
      set;
    } = new List<SelectListItem>();

    public IEnumerable<SelectListItem> Anos
    {
      get;
      set;
    } = new List<SelectListItem>();
  }
}