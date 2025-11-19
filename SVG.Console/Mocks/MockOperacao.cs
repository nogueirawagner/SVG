using SVG.App.Interface;
using SVG.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SVG.Console.Mocks
{
  public class MockOperacao : Mock
  {
    private readonly IOperacaoAppService _operacaoAppService;

    public MockOperacao(
      IOperacaoAppService operacaoAppService,
      bool seed = false,
      bool kill = false,
      bool run = true
      ) : base(seed, kill, run)
    {
      _operacaoAppService = operacaoAppService;
    }

    public override void Seed()
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
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddDays(-10).AddHours(-3),
            Objeto = "Escolta de preso de alta periculosidade",
            DP = "15ª DP",
            Coordenador = "Nogueira",
            QtdEquipe = 3
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddDays(-9).AddHours(-2),
            Objeto = "Audiência no Fórum Criminal",
            DP = "5ª DP",
            Coordenador = "Higor",
            QtdEquipe = 2
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddDays(-8).AddHours(-5),
            Objeto = "Transferência interestadual de custodiado",
            DP = "CORP",
            Coordenador = "Arana",
            QtdEquipe = 4
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddDays(-7).AddHours(-1),
            Objeto = "Cumprimento de mandado de prisão",
            DP = "20ª DP",
            Coordenador = "Wanderson",
            QtdEquipe = 2
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddDays(-6).AddHours(-6),
            Objeto = "Operação conjunta com Polícia Civil",
            DP = "2ª DP",
            Coordenador = "Medina",
            QtdEquipe = 3
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddDays(-5).AddHours(-4),
            Objeto = "Escolta para unidade hospitalar",
            DP = "19ª DP",
            Coordenador = "Benevides",
            QtdEquipe = 1
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddDays(-4).AddHours(-2),
            Objeto = "Recolhimento de preso em unidade prisional",
            DP = "DFP",
            Coordenador = "Sidney",
            QtdEquipe = 2
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddDays(-3).AddHours(-3),
            Objeto = "Patrulhamento tático em área de risco",
            DP = "Ceilândia",
            Coordenador = "Wanderson",
            QtdEquipe = 3
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddDays(-2).AddHours(-1),
            Objeto = "Operação de captura de foragido",
            DP = "Taguatinga",
            Coordenador = "Nogueira",
            QtdEquipe = 2
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddDays(-1).AddHours(-2),
            Objeto = "Escolta para julgamento no Tribunal do Júri",
            DP = "TJDFT",
            Coordenador = "Chiarelli",
            QtdEquipe = 3
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddHours(-6),
            Objeto = "Transferência de liderança de facção",
            DP = "DCCP",
            Coordenador = "Cassis",
            QtdEquipe = 4
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddHours(-4),
            Objeto = "Operação de varredura em cela de segurança máxima",
            DP = "Presídio Federal",
            Coordenador = "Lebrão",
            QtdEquipe = 2
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddHours(-2),
            Objeto = "Escolta para audiência em Vara de Execuções Penais",
            DP = "VEP",
            Coordenador = "Rayssa",
            QtdEquipe = 1
        },
        new Operacao
        {
            DataHora = DateTime.Now.AddHours(-1),
            Objeto = "Remanejamento de presos entre unidades",
            DP = "SEAPE",
            Coordenador = "Medina",
            QtdEquipe = 3
        },
        new Operacao
        {
            DataHora = DateTime.Now,
            Objeto = "Escolta preventiva em deslocamento de autoridade",
            DP = "GAB",
            Coordenador = "Nogueira",
            QtdEquipe = 2
        }
      };

      _operacaoAppService.AddRange(operacoes);
    }

    public override void Kill()
    {
      _operacaoAppService.GetAll().ToList().ForEach(op => _operacaoAppService.Remove(op));
    }
  }
}
