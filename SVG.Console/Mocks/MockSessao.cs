using SVG.App.Interface;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockSessao
  {
    private readonly ISessaoAppService _SessaoAppService;

    public MockSessao(ISessaoAppService SessaoAppService)
    {
      _SessaoAppService = SessaoAppService;
      Seed();
    }

    private void Seed()
    {
      var Sessaos = new List<Sessao>
      {
        new Sessao { Nome = "SOE I" },
        new Sessao { Nome = "SOE II" },
        new Sessao { Nome = "SOE III" },
        new Sessao { Nome = "SOE IV" },
        new Sessao { Nome = "SOR" },
        new Sessao { Nome = "SOT" },
        new Sessao { Nome = "SI" }
      };

      _SessaoAppService.AddRange(Sessaos);
    }
  }
}
