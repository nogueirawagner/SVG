using System.Collections.Generic;

namespace SVG.Domain.Entities
{
  public class Viatura
  {
    public int ID { get; set; }
    public string Modelo { get; set; }
    public string Prefixo { get; set; }
    public string Placa { get; set; }

    // FK da Sessão
    public int SessaoID { get; set; }
    public virtual Sessao Sessao { get; set; }

    public virtual ICollection<ViaturaOperacao> ViaturasOperacao { get; set; }

    public Viatura()
    {
      ViaturasOperacao = new List<ViaturaOperacao>();
    }
  }

}
