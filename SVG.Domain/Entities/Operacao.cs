namespace SVG.Domain.Entities
{
  public class Operacao
  {
    public int ID { get; set; }
    public DateTime DataHora { get; set; }
    public DateTime DataHoraCriacao { get; set; }
    public string Objeto { get; set; }
    public string OrdemServico { get; set; }
    public string Coordenador { get; set; }
    public int QtdEquipe { get; set; }
    public int TipoOperacaoID { get; set; }
    public bool SvgAberto { get; set; }

    public virtual TipoOperacao TipoOperacao { get; set; }
    public virtual ICollection<OperadorOperacao> OperadoresOperacao { get; set; }
    public virtual ICollection<ViaturaOperacao> ViaturasOperacao { get; set; }

    public Operacao()
    {
      OperadoresOperacao = new List<OperadorOperacao>();
      ViaturasOperacao = new List<ViaturaOperacao>();
    }
  }
}
