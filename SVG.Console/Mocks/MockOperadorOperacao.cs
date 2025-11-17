using SVG.App.Interface;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockOperadorOperacao
  {
    private readonly IOperadorOperacaoAppService _operadorOperacaoAppService;

    public MockOperadorOperacao(IOperadorOperacaoAppService operadorOperacaoAppService)
    {
      _operadorOperacaoAppService = operadorOperacaoAppService;
      Seed();
    }

    private void Seed()
    {
      var operadoresOperacoes = new List<OperadorOperacao>
      {
        new OperadorOperacao { OperacaoID = 1, OperadorID = 1, SVG = true,  Equipe = 1 },
        new OperadorOperacao { OperacaoID = 1, OperadorID = 2, SVG = false, Equipe = 1 },
        new OperadorOperacao { OperacaoID = 2, OperadorID = 3, SVG = true,  Equipe = 2 }
      };

      _operadorOperacaoAppService.AddRange(operadoresOperacoes);
    }
  }
}
