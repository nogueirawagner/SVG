using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.TiposEstruturados.TiposOperador
{
  public enum XTipoImpedimentoOperador
  {
    PunicaoDisciplinarOuAdministrativa = 1,

    PorteArmaSuspensoOuCassado = 2,

    RestricaoMedicaOperacional = 3,

    GestanteLactanteRegimeDiferenciado = 4,

    CedidoOuRequisitado = 5,

    HorarioEspecialOuReducaoCargaHoraria = 6,

    TreinamentoObrigatorioPendente = 7,

    PenalidadeSVG = 8,

    Outros = 99
  }
}
