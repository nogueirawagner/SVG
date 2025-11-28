using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.Operacao
{
  public class DetalhesOperacao
  {
    public int ID { get; set; }
    public DateTime DataHoraCriacao { get; set; }
    public DateTime DataHora { get; set; }
    public string Objeto { get; set; }
    public string DP { get; set; }
    public int QtdEquipe { get; set; }
    public string Coordenador { get; set; }
    public string TipoOperacao { get; set; }
    public int OperadorID { get; set; }
    public string NomeOperador { get; set; }
    public string Matricula { get; set; }
    public string Telefone { get; set; }
    public bool SVG { get; set; }
    public string Sessao { get; set; }
  }

}
