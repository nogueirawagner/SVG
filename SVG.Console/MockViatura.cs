using SVG.App.Interface;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console
{
  public class MockViatura
  {
    private readonly IViaturaAppService _viaturaAppService;

    public MockViatura(IViaturaAppService viaturaAppService)
    {
      _viaturaAppService = viaturaAppService;
      Seed();
    }

    private void Seed()
    {
      var viaturas = new List<Viatura>
      {
        new Viatura { Modelo = "Trailblazer", Prefixo = "DOE-01", Placa = "ABC1D23" },
        new Viatura { Modelo = "Hilux",       Prefixo = "DOE-02", Placa = "EFG4H56" },
        new Viatura { Modelo = "SW4",         Prefixo = "DOE-03", Placa = "IJK7L89" }
      };

      _viaturaAppService.AddRange(viaturas);
    }
  }
}
