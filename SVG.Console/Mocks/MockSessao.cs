using SVG.App.Interface;
using SVG.App.Services;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockSessao : Mock
  {
    private readonly ISessaoAppService _sessaoAppService;

    public MockSessao(
            ISessaoAppService sessaoAppService,
            bool seed = false,
            bool kill = false,
            bool run = true
        ) : base()
    {
      _sessaoAppService = sessaoAppService;
      Execute(seed, kill, run);
    }

    protected override void Seed()
    {
      var sessao = new List<Sessao>
      {
        new Sessao { Nome = "SOE I" }, // ID = 1
        new Sessao { Nome = "SOE II" }, // ID = 2
        new Sessao { Nome = "SOE III" }, // ID = 3
        new Sessao { Nome = "SOE IV" }, // ID = 4
        new Sessao { Nome = "SOR" }, // ID = 5
        new Sessao { Nome = "SOT" }, // ID = 6
        new Sessao { Nome = "SI" }, // ID = 7
        new Sessao { Nome = "SOC" }, // ID = 8
        new Sessao { Nome = "GAB" }  // ID = 9
      };

      _sessaoAppService.AddRange(sessao);
    }

    protected override void Kill()
    {
      _sessaoAppService.GetAll().ToList().ForEach(op => _sessaoAppService.Remove(op));
    }
  }
}