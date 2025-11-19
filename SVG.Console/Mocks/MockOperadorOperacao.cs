using SVG.App.Interface;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockOperadorOperacao : Mock
  {
    private readonly IOperadorOperacaoAppService _operadorOperacaoAppService;

    public MockOperadorOperacao(
        IOperadorOperacaoAppService operadorOperacaoAppService,
        bool seed = false,
        bool kill = false,
        bool run = true
      ) : base()
    {
      _operadorOperacaoAppService = operadorOperacaoAppService;
      Execute(seed, kill, run);
    }

    protected override void Seed()
    {
      var operadoresOperacoes = new List<OperadorOperacao>
      {
        new OperadorOperacao { OperacaoID = 1, OperadorID = 1, SVG = true,  Equipe = 1 },
        new OperadorOperacao { OperacaoID = 1, OperadorID = 2, SVG = false, Equipe = 1 },
        new OperadorOperacao { OperacaoID = 2, OperadorID = 3, SVG = true,  Equipe = 2 }
      };

      _operadorOperacaoAppService.AddRange(operadoresOperacoes);
    }

    protected override void Kill()
    {
      _operadorOperacaoAppService.GetAll().ToList().ForEach(op => _operadorOperacaoAppService.Remove(op));
    }
  }
}
