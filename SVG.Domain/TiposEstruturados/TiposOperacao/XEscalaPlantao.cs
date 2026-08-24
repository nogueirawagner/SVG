using SVG.Domain.TiposEstruturados.Enums;

namespace SVG.Domain.TiposEstruturados.TiposOperacao
{
  public class XEscalaPlantao
  {
    public int SecaoID { get; set; }
    public int SecaoSobreavisoID { get; set; }
    public string Nome { get; set; }
    public DateTime DataPlantao { get; set; }
    public XSituacaoPlantao Situacao { get; set; }
    public string SecaoSobreaviso { get; set; }
  }
}
