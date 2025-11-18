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

    public void Seed()
    {
      var operacoes = new List<Operacao>
      {
        new Operacao
        {
          DataHora = DateTime.Now.AddHours(-2),
          Objeto = "Apoio",
          DP = "15ª DP",
          Coordenador = "Nogueira",
          QtdEquipe = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddHours(-1),
          Objeto = "Delta",
          DP = "10ª DP",
          Coordenador = "Higor",
          QtdEquipe = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now,
          Objeto = "Alvorada",
          DP = "",
          Coordenador = "Leandro",
          QtdEquipe = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now,
          Objeto = "Segurança Orgânica",
          DP = "",
          Coordenador = "Arana",
          QtdEquipe = 1
        }
      };

      _operacaoAppService.AddRange(operacoes);
    }

    public void Kill()
    {
      _operacaoAppService.GetAll().ToList().ForEach(op => _operacaoAppService.Remove(op));
    }
  }
}
