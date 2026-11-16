using System.ComponentModel;

namespace SVG.Domain.TiposEstruturados.Enums;

// Os valores definem a ordem de apresentação e são persistidos no banco.
public enum XSubgrupoImagemPlanejamento
{
    [Description("DOE - Alvo")] DOEAlvo = 1,
    [Description("PRPO")] PRPO = 2,
    [Description("DROP-OFF")] DropOff = 3,
    [Description("Imagens do Alvo")] ImagensAlvo = 4
}
