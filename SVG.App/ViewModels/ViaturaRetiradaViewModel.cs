using Microsoft.AspNetCore.Mvc.Rendering;
using SVG.Domain.TiposEstruturados.Enums;

namespace SVG.WebApp.Models
{
  public class ViaturaRetiradaViewModel
  {
    public int ViaturaID { get; set; }

    public string Prefixo { get; set; }

    public string Placa { get; set; }

    public string Modelo { get; set; }

    public string Secao { get; set; }

    public int QuilometragemAtual { get; set; }

    public int OperadorID { get; set; }

    public XFinalidadeViatura Finalidade { get; set; }

    public string Observacao { get; set; }

    public IEnumerable<SelectListItem> Operadores { get; set; }
  }
}