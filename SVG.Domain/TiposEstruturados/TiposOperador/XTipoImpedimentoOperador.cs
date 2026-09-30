using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.TiposOperador
{
  public enum XTipoImpedimentoOperador
  {
    [Description("Punição disciplinar ou administrativa")]
    PunicaoDisciplinarOuAdministrativa = 1,

    [Description("Porte de arma suspenso ou cassado")]
    PorteArmaSuspensoOuCassado = 2,

    [Description("Restrição médica operacional")]
    RestricaoMedicaOperacional = 3,

    [Description("Gestante ou lactante em regime diferenciado")]
    GestanteLactanteRegimeDiferenciado = 4,

    [Description("Cedido ou requisitado")]
    CedidoOuRequisitado = 5,

    [Description("Horário especial ou redução de carga horária")]
    HorarioEspecialOuReducaoCargaHoraria = 6,

    [Description("Treinamento obrigatório pendente")]
    TreinamentoObrigatorioPendente = 7,

    [Description("Penalidade de SVG")]
    PenalidadeSVG = 8,

    [Description("Outros")]
    Outros = 99
  }
}
