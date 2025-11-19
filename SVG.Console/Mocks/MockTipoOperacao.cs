using SVG.App.Interface;
using SVG.App.Services;
using SVG.Domain.Entities;

namespace SVG.Console.Mocks
{
  public class MockTipoOperacao : Mock
  {
    private readonly ITipoOperacaoAppService _tipoOperacaoAppService;

    public MockTipoOperacao(
      ITipoOperacaoAppService tipoOperacaoAppService,
      bool seed = false,
      bool kill = false,
      bool run = true)
    {
      _tipoOperacaoAppService = tipoOperacaoAppService;
      Execute(seed, kill, run); 
    }

    protected override void Seed()
    {
      var tipos = new List<TipoOperacao>
      {
          new TipoOperacao { Nome = "Apoio", Peso = 5 },
          new TipoOperacao { Nome = "Alvorada", Peso = 2 },
          new TipoOperacao { Nome = "Delta", Peso = 3 },
          new TipoOperacao { Nome = "Segurança Orgânica", Peso = 1 }
      };

      _tipoOperacaoAppService.AddRange(tipos);
    }

    protected override void Kill()
    {
      _tipoOperacaoAppService.GetAll().ToList().ForEach(op => _tipoOperacaoAppService.Remove(op));
    }
  }
}
