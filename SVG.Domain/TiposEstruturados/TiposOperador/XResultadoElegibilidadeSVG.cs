namespace SVG.Domain.TiposEstruturados.TiposOperador
{
  public class XResultadoElegibilidadeSVG
  {
    public XResultadoElegibilidadeSVG()
    {
      Motivos = new List<string>();
    }

    public bool Elegivel
    {
      get { return !Motivos.Any(); }
    }

    public List<string> Motivos { get; set; }

    public DateTime? ImpedidoAte { get; set; }
  }
}
