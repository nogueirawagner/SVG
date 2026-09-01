using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.TiposOperador
{
  public class XOperadoresSecaoOrdemSVG
  {
    public int OperadorID { get; set; }
    public int NumericaDOE { get; set; }
    public int QtdOperacoes { get; set; }
    public int QtdHoras { get; set; }
    public double EngajamentoOperador { get; set; }
    public string Secao { get; set; }
    public string SituacaoEquipe { get; set; }
    public int PesoEquipe { get; set; }
    public int OrdemNaEquipe { get; set; } // ordem do operador naquele momento dentro da equipe.
  }
}
