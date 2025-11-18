using SVG.App.Interface;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockViaturaOperacao
  {
    private readonly IViaturaOperacaoAppService _viaturaOperacaoAppService;

    public MockViaturaOperacao(IViaturaOperacaoAppService viaturaOperacaoAppService)
    {
      _viaturaOperacaoAppService = viaturaOperacaoAppService;
      
      Kill();
      Seed();
    }

    public void Seed()
    {
      var viaturasOperacoes = new List<ViaturaOperacao>
      {
        new ViaturaOperacao { OperacaoID = 1, ViaturaID = 1 },
        new ViaturaOperacao { OperacaoID = 1, ViaturaID = 2 },
        new ViaturaOperacao { OperacaoID = 2, ViaturaID = 3 }
      };

      _viaturaOperacaoAppService.AddRange(viaturasOperacoes);
    }

    public void Kill()
    {
      _viaturaOperacaoAppService.GetAll().ToList().ForEach(op => _viaturaOperacaoAppService.Remove(op));
    }
  }
}
