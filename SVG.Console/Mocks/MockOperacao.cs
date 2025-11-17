using SVG.App.Interface;
using SVG.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockOperacao
  {
    private readonly IOperacaoAppService _operacaoAppService;

    public MockOperacao(IOperacaoAppService operacaoAppService)
    {
      _operacaoAppService = operacaoAppService;
      Seed();
    }

    private void Seed()
    {
      var operacoes = new List<Operacao>
      {
        new Operacao
        {
          DataHora = DateTime.Now.AddHours(-2),
          Objeto = "Escolta de preso de alto risco",
          DP = "15ª DP",
          Coordenador = "Nogueira",
          QtdEquipe = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddHours(-1),
          Objeto = "Operação de captura",
          DP = "10ª DP",
          Coordenador = "Higor",
          QtdEquipe = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now,
          Objeto = "Cumprimento de mandado",
          DP = "20ª DP",
          Coordenador = "Arana",
          QtdEquipe = 1
        }
      };

      _operacaoAppService.AddRange(operacoes);
    }
  }
}
