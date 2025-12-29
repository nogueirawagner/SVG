using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.TiposOperador
{
  public class XDetalhamentoOperadorOperacao
  {
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string Telefone { get; set; }
    public string Sessao { get; set; }
    public string TipoOperacao { get; set; }
    public int Peso { get; set; }
    public int QtdOperacoes { get; set; }
    public bool SVG { get; set; }
  }
}
