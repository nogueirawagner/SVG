using Microsoft.AspNetCore.Mvc.Rendering;
using SVG.Domain.TiposEstruturados.TiposOperador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.App.ViewModels
{
  public class AfastamentoOperadorListarViewModel
  {
    // =========================
    // FILTROS
    // =========================

    public int? OperadorID { get; set; }

    public int? SessaoID { get; set; }

    public XTipoAfastamento? TipoAfastamento { get; set; }

    public int? Ano { get; set; }

    public int? Mes { get; set; }

    public DateTime? PeriodoInicio { get; set; }

    public DateTime? PeriodoFim { get; set; }

    // =========================
    // COMBOS
    // =========================

    public IEnumerable<SelectListItem> Operadores { get; set; }

    public IEnumerable<SelectListItem> Sessoes { get; set; }

    public IEnumerable<SelectListItem> Anos { get; set; }

    // =========================
    // RESULTADO
    // =========================

    public IEnumerable<AfastamentoOperadorViewModel> Afastamentos { get; set; }
  }
}
