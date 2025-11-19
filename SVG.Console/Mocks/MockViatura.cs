using SVG.App.Interface;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockViatura : Mock
  {
    private readonly IViaturaAppService _viaturaAppService;

    public MockViatura(
        IViaturaAppService viaturaAppService,
        bool seed = false,
        bool kill = false,
        bool run = true
        ) : base(seed, kill, run)
    {
      _viaturaAppService = viaturaAppService;
    }

    public override void Seed()
    {
      var viaturas 
        = new List<Viatura>
        {
            new Viatura { Modelo = "Trailblazer", Prefixo = "DOE-01", Placa = "AQQ1D23", SessaoID = 1 }, 
            new Viatura { Modelo = "Trailblazer", Prefixo = "DOE-01", Placa = "QBA1D24", SessaoID = 1 }, 
            new Viatura { Modelo = "Hilux", Prefixo = "DOE-02", Placa = "EFG4H45", SessaoID = 2 }, 
            new Viatura { Modelo = "Hilux", Prefixo = "DOE-02", Placa = "EDD4H55", SessaoID = 2 }, 
            new Viatura { Modelo = "SW4", Prefixo = "DOE-03", Placa = "IAK7L61", SessaoID = 3 },  
            new Viatura { Modelo = "SW4", Prefixo = "DOE-03", Placa = "IJA7L65", SessaoID = 3 },  
            new Viatura { Modelo = "SW4", Prefixo = "DOE-03", Placa = "AAJ7L83", SessaoID = 4 },  
            new Viatura { Modelo = "SW4", Prefixo = "DOE-03", Placa = "ABK7L84", SessaoID = 4 },  
            new Viatura { Modelo = "SW4", Prefixo = "DOE-03", Placa = "QEK7L85", SessaoID = 5 },  
            new Viatura { Modelo = "SW4", Prefixo = "DOE-03", Placa = "REK7L86", SessaoID = 5 },  
            new Viatura { Modelo = "SW4", Prefixo = "DOE-03", Placa = "GFK7L87", SessaoID = 6 },  
            new Viatura { Modelo = "SW4", Prefixo = "DOE-03", Placa = "QQK7L88", SessaoID = 6 }  
        };

      _viaturaAppService.AddRange(viaturas);
    }

    public override void Kill()
    {
      _viaturaAppService.GetAll().ToList().ForEach(op => _viaturaAppService.Remove(op));
    }
  }
}
