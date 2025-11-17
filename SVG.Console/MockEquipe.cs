using SVG.App.Interface;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console
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
        new Equipe { Nome = "Equipe Alfa" },
        new Equipe { Nome = "Equipe Bravo" },
        new Equipe { Nome = "Equipe Charlie" }
      };

      _equipeAppService.AddRange(equipes);
    }
  }
}
