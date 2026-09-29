using System.ComponentModel;

namespace SVG.Domain.TiposEstruturados.TiposOperador
{
  public enum XTipoAfastamento
  {
    [Description("Férias")]
    Ferias = 1,

    [Description("Abono de ponto anual")]
    AbonoPontoAnual = 2,

    [Description("Abono de aniversário")]
    AbonoAniversario = 3,

    [Description("Licença para capacitação")]
    LicencaCapacitacao = 4,

    [Description("Licença-prêmio por assiduidade")]
    LicencaPremioAssiduidade = 5,

    [Description("Licença para tratar de interesse particular")]
    LicencaInteresseParticular = 6,

    [Description("Licença para tratamento de saúde de pessoa da família")]
    LicencaSaudePessoaFamilia = 7,

    [Description("Licença para tratamento de saúde própria")]
    LicencaSaudePropria = 8,

    [Description("Licença para desempenho de mandato classista")]
    LicencaMandatoClassista = 9,

    [Description("Licença por motivo de afastamento do cônjuge ou companheiro")]
    LicencaAfastamentoConjugeCompanheiro = 10,

    [Description("Afastamento para missão ou curso no exterior")]
    MissaoCursoExterior = 11,

    [Description("Outros")]
    Outros = 99
  }
}
