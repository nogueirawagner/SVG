using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.Operador
{
  public class ResumoOperadorOperacao
  {
    public int OperadorID { get; set; }
    public string OperadorNome { get; set; }
    public string Matricula { get; set; }
    public string Telefone { get; set; }
    public string Sessao { get; set; }
    public int QtdOperacoes { get; set; }
    public int QtdOperacoesSVG { get; set; }
    public double MediaPonderada { get; set; }
  }
}
