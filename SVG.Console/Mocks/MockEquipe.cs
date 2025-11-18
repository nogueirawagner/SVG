using SVG.App.Interface;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockEquipe
  {
    private readonly IEquipeAppService _equipeAppService;

    public MockEquipe(IEquipeAppService equipeAppService)
    {
      _equipeAppService = equipeAppService;
      Seed();
    }

    private void Seed()
    {
      var equipes = new List<Equipe>
      {
        new Equipe { Nome = "SOE I" },
        new Equipe { Nome = "SOE II" },
        new Equipe { Nome = "SOE III" },
        new Equipe { Nome = "SOE IV" },
        new Equipe { Nome = "SOR" },
        new Equipe { Nome = "SOT" },
        new Equipe { Nome = "SI" }
      };

      _equipeAppService.AddRange(equipes);
    }
  }
}
