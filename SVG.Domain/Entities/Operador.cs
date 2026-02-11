using SVG.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Entities
{
  public class Operador
  {
    public int ID { get; set; }
    public string Matricula { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Alcunha { get; set; } 
    
    // FK da Sessão
    public int SessaoID { get; set; }
    public virtual Sessao Sessao { get; set; }
    public Usuario? Usuario { get; set; }

    public virtual ICollection<CandidatoSVGOperacao> CandidatosSVGOperacao { get; set; }

    public Operador()
    {
      CandidatosSVGOperacao = new List<CandidatoSVGOperacao>();
    }
  }
}
