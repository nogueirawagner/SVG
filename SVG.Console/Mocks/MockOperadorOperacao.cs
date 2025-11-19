using Microsoft.AspNetCore.Hosting;
using SVG.App.Interface;
using SVG.App.Services;
using SVG.Domain.Entities;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockOperadorOperacao : Mock
  {
    private readonly IOperadorOperacaoAppService _operadorOperacaoAppService;
    private readonly IOperacaoAppService _operacaoAppService;
    private readonly IOperadorAppService _operadorAppService;

    public MockOperadorOperacao(
        IOperadorOperacaoAppService operadorOperacaoAppService,
        IOperacaoAppService operacaoAppService,
        IOperadorAppService operadorAppService,
        bool seed = false,
        bool kill = false,
        bool run = true
      ) : base()
    {
      _operadorOperacaoAppService = operadorOperacaoAppService;
      _operacaoAppService = operacaoAppService;
      _operadorAppService = operadorAppService;

      Execute(seed, kill, run);
    }

    protected override void Seed()
    {
      var operadores = _operadorAppService.GetAll().ToList();
      var operacoes = _operacaoAppService.GetAll().ToList();

      if (!operadores.Any() || !operacoes.Any())
        return;

      var listOperadores = new List<OperadorOperacao>();

      var totalOperadores = operadores.Count;
      var rnd = new Random();
      var listOperAux = new List<Operador>();

      // Garante que para CADA operação teremos pelo menos 10 operadores
      foreach (var operacao in operacoes.OrderBy(o => o.DataHora))
      {
        listOperAux.Clear();

        var quantidadePorOperacao = rnd.Next(8, 12);
        if (totalOperadores < quantidadePorOperacao)
        {
          quantidadePorOperacao = totalOperadores; // se tiver menos de 10 operadores na base
        }

        for (int i = 0; i < quantidadePorOperacao; i++)
        {
          var operador = operadores[rnd.Next(totalOperadores)];
          
          while(true)
          {
            if (!listOperAux.Contains(operador))
            {
              listOperAux.Add(operador);
              break;
            }
            operador = operadores[rnd.Next(totalOperadores)];
          }
          
          listOperadores.Add(new OperadorOperacao
          {
            OperacaoID = operacao.ID,
            OperadorID = operador.ID,
            SVG = rnd.NextBool(80),   // ou false / alterna se quiser
            // Preencha outros campos se existirem (ex.: Sessao, Equipe etc.)
          });
        }
      }

      _operadorOperacaoAppService.AddRange(listOperadores);
    }


    protected override void Kill()
    {
      _operadorOperacaoAppService.GetAll().ToList().ForEach(op => _operadorOperacaoAppService.Remove(op));
    }
  }
}
