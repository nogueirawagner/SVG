using SVG.Domain.TiposEstruturados.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Entities
{
  public class ViaturaMovimentacao
  {
    public int ID { get; set; }

    public int ViaturaID { get; set; }
    public virtual Viatura Viatura { get; set; }

    public int OperadorID { get; set; }
    public virtual Operador Operador { get; set; }

    // Usuário autenticado que registrou a movimentação; NULL apenas para registros legados.
    public int? OperadorResponsavelID { get; set; }
    public virtual Operador? OperadorResponsavel { get; set; }

    public XFinalidadeViatura Finalidade { get; set; }

    public XSituacaoViatura Situacao { get; set; }  

    public DateTime DataHoraRetirada { get; set; }
    public DateTime? DataHoraDevolucao { get; set; }

    public int? NivelCombustivelRetirada { get; set; }
    public int? NivelCombustivelDevolucao { get; set; }

    public int KmInicial { get; set; }
    public int? KmFinal { get; set; }
    public int? KmAbastecimento { get; set; }
    public bool Abastecimento { get; set; }


    public string Observacao { get; set; }
  }
}
