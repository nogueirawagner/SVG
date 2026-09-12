using Microsoft.AspNetCore.Mvc.Rendering;

namespace SVG.WebApp.Models
{
  public class ViaturaDevolucaoViewModel
  {
    public int ViaturaID { get; set; }

    public string Prefixo { get; set; }

    public string Placa { get; set; }

    public string Modelo { get; set; }

    public int OperadorID { get; set; }

    public IEnumerable<SelectListItem> Operadores { get; set; }
  }
}