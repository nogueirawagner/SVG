using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.Enums;
using SVG.Domain.TiposEstruturados.Viatura;

public class Viatura
{
  public int ID { get; set; }

  public string Prefixo { get; set; }
  public string Placa { get; set; }
  public string Marca { get; set; }
  public string Modelo { get; set; }
  public int? Ano { get; set; }

  // Seção à qual a viatura está alocada
  public int SessaoID { get; set; }
  public virtual Sessao Sessao { get; set; }

  // Operador responsável pela viatura
  public int? OperadorResponsavelID { get; set; }
  public virtual Operador Operador { get; set; }

  public XTipoCaracterizacaoViatura TipoCaracterizacao { get; set; }

  public int QuilometragemAtual { get; set; }

  public XSituacaoViatura Situacao { get; set; }

  public virtual ICollection<XViaturaMovimentacao> Movimentacoes { get; set; }
}