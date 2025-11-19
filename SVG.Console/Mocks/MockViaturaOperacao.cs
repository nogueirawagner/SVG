using SVG.App.Interface;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockViaturaOperacao : Mock
  {
    private readonly IViaturaOperacaoAppService _viaturaOperacaoAppService;

    public MockViaturaOperacao(
        IViaturaOperacaoAppService viaturaOperacaoAppService,
        bool seed = false,
        bool kill = false,
        bool run = true
      ) : base(seed, kill, run)
    {
      _viaturaOperacaoAppService = viaturaOperacaoAppService;
    }

    public override void Seed()
    {
      var viaturasOperacoes = new List<ViaturaOperacao>
      {
        new ViaturaOperacao { OperacaoID = 1, ViaturaID = 1 },
        new ViaturaOperacao { OperacaoID = 1, ViaturaID = 2 },
        new ViaturaOperacao { OperacaoID = 2, ViaturaID = 3 }
      };

      _viaturaOperacaoAppService.AddRange(viaturasOperacoes);
    }

    public override void Kill()
    {
      _viaturaOperacaoAppService.GetAll().ToList().ForEach(op => _viaturaOperacaoAppService.Remove(op));
    }
  }
}
