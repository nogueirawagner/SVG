using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.App.ViewModels
{
  public class OperacaoViewModel
  {
    public int ID { get; set; }
    public DateTime DataHora { get; set; }
    public string Objeto { get; set; }
    public string DP { get; set; }

    // ainda pode existir a string Coordenador (que grava o nome na entidade)
    public string Coordenador { get; set; }

    // usado para selecionar o coordenador pelo ID do operador
    public int CoordenadorOperadorID { get; set; }

    public int QtdEquipe { get; set; }

    public int TipoOperacaoID { get; set; }
    public string TipoOperacaoNome { get; set; }

    // lista de operadores selecionados (IDs)
    public List<int> OperadoresSelecionados { get; set; } = new List<int>();
  }

}
