using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.WebApp.Models
{
  public class AfastamentosSecaoViewModel
  {
    public int Mes { get; set; }

    public int Ano { get; set; }

    public int SecaoID { get; set; }

    public string SecaoNome { get; set; }

    public IEnumerable<AfastamentoOperador> Afastamentos { get; set; }
        = new List<AfastamentoOperador>();
  }
}