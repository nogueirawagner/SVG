using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.Enums;
using SVG.Domain.TiposEstruturados.TiposViatura;

namespace SVG.Domain.Entities
{
  public class Viatura
  {
    public int ID { get; set; }

    public string Prefixo { get; set; }
    public string Placa { get; set; }
    public string PlacaOficial { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int? Ano { get; set; }

    // Seção à qual a viatura está alocada
    public int SessaoID { get; set; }
    public virtual Sessao Sessao { get; set; }

    // Operador responsável pela viatura
    public int? OperadorResponsavelID { get; set; }
    public virtual Operador OperadorResponsavel { get; set; }

    public XTipoCaracterizacaoViatura TipoCaracterizacao { get; set; }
    public int KmAtual { get; set; }
    public int? KmUltimoAbastecimento { get; set; }
    public int? KmProximaRevisao  { get; set; }
    public string Chassi { get; set; }
    public XSituacaoViatura Situacao { get; set; }

    public virtual ICollection<ViaturaMovimentacao> Movimentacoes { get; set; }
  }
}