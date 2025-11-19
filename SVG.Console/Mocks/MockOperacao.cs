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
      ) : base()
    {
      _operacaoAppService = operacaoAppService;
      Execute(seed, kill, run);
    }

    protected override void Seed()
    {
      var operacoes = new List<Operacao>
      {
        new Operacao
        {
          DataHora = DateTime.Now.AddHours(-2),
          Objeto = "Apoio",
          DP = "15ª DP",
          Coordenador = "Nogueira",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddHours(-1),
          Objeto = "Delta",
          DP = "10ª DP",
          Coordenador = "Higor",
          QtdEquipe = 3,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now,
          Objeto = "Alvorada",
          DP = "",
          Coordenador = "Leandro",
          QtdEquipe = 1,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now,
          Objeto = "Segurança Orgânica",
          DP = "",
          Coordenador = "Arana",
          QtdEquipe = 1,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-10).AddHours(-3),
          Objeto = "Escolta de preso de alta periculosidade",
          DP = "15ª DP",
          Coordenador = "Nogueira",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-9).AddHours(-2),
          Objeto = "Audiência no Fórum Criminal",
          DP = "5ª DP",
          Coordenador = "Higor",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-8).AddHours(-5),
          Objeto = "Transferência interestadual de custodiado",
          DP = "CORP",
          Coordenador = "Arana",
          QtdEquipe = 4,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-7).AddHours(-1),
          Objeto = "Cumprimento de mandado de prisão",
          DP = "20ª DP",
          Coordenador = "Wanderson",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-6).AddHours(-6),
          Objeto = "Operação conjunta com Polícia Civil",
          DP = "2ª DP",
          Coordenador = "Medina",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-5).AddHours(-4),
          Objeto = "Escolta para unidade hospitalar",
          DP = "19ª DP",
          Coordenador = "Benevides",
          QtdEquipe = 1,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-4).AddHours(-2),
          Objeto = "Recolhimento de preso em unidade prisional",
          DP = "DFP",
          Coordenador = "Sidney",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-3).AddHours(-3),
          Objeto = "Patrulhamento tático em área de risco",
          DP = "Ceilândia",
          Coordenador = "Wanderson",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-2).AddHours(-1),
          Objeto = "Operação de captura de foragido",
          DP = "Taguatinga",
          Coordenador = "Nogueira",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-1).AddHours(-2),
          Objeto = "Escolta para julgamento no Tribunal do Júri",
          DP = "TJDFT",
          Coordenador = "Chiarelli",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddHours(-6),
          Objeto = "Transferência de liderança de facção",
          DP = "DCCP",
          Coordenador = "Cassis",
          QtdEquipe = 4,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddHours(-4),
          Objeto = "Operação de varredura em cela de segurança máxima",
          DP = "Presídio Federal",
          Coordenador = "Lebrão",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddHours(-2),
          Objeto = "Escolta para audiência em Vara de Execuções Penais",
          DP = "VEP",
          Coordenador = "Rayssa",
          QtdEquipe = 1,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddHours(-1),
          Objeto = "Remanejamento de presos entre unidades",
          DP = "SEAPE",
          Coordenador = "Medina",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now,
          Objeto = "Escolta preventiva em deslocamento de autoridade",
          DP = "GAB",
          Coordenador = "Nogueira",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now,
          Objeto = "Escolta preventiva em deslocamento de autoridade",
          DP = "GAB",
          Coordenador = "Nogueira",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-15).AddHours(-1),
          Objeto = "Apoio",
          DP = "10ª DP",
          Coordenador = "Higor",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-15).AddHours(-2),
          Objeto = "Delta",
          DP = "1ª DP",
          Coordenador = "Arana",
          QtdEquipe = 4,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-15).AddHours(-3),
          Objeto = "Segurança Orgânica",
          DP = "12ª DP",
          Coordenador = "Nogueira",
          QtdEquipe = 3,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-15).AddHours(-4),
          Objeto = "Alvorada",
          DP = "6ª DP",
          Coordenador = "Wanderson",
          QtdEquipe = 2,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-15).AddHours(-5),
          Objeto = "Apoio",
          DP = "9ª DP",
          Coordenador = "Medina",
          QtdEquipe = 1,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-15).AddHours(-6),
          Objeto = "Delta",
          DP = "7ª DP",
          Coordenador = "Sidartha",
          QtdEquipe = 3,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-15).AddHours(-7),
          Objeto = "Segurança Orgânica",
          DP = "Ceilândia",
          Coordenador = "Cassis",
          QtdEquipe = 2,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-15).AddHours(-8),
          Objeto = "Alvorada",
          DP = "Taguatinga",
          Coordenador = "Chiarelli",
          QtdEquipe = 4,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-15).AddHours(-9),
          Objeto = "Apoio",
          DP = "Planaltina",
          Coordenador = "Sidney",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-15).AddHours(-10),
          Objeto = "Delta",
          DP = "TJDFT",
          Coordenador = "Rayssa",
          QtdEquipe = 2,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-20).AddHours(-1),
          Objeto = "Segurança Orgânica",
          DP = "10ª DP",
          Coordenador = "Higor",
          QtdEquipe = 3,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-20).AddHours(-2),
          Objeto = "Alvorada",
          DP = "5ª DP",
          Coordenador = "Nogueira",
          QtdEquipe = 1,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-20).AddHours(-3),
          Objeto = "Apoio",
          DP = "8ª DP",
          Coordenador = "Medina",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-20).AddHours(-4),
          Objeto = "Delta",
          DP = "12ª DP",
          Coordenador = "Arana",
          QtdEquipe = 4,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-20).AddHours(-5),
          Objeto = "Apoio",
          DP = "2ª DP",
          Coordenador = "Wanderson",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-20).AddHours(-6),
          Objeto = "Segurança Orgânica",
          DP = "15ª DP",
          Coordenador = "Cassis",
          QtdEquipe = 2,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-20).AddHours(-7),
          Objeto = "Delta",
          DP = "20ª DP",
          Coordenador = "Sidartha",
          QtdEquipe = 4,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-20).AddHours(-8),
          Objeto = "Apoio",
          DP = "Ceilândia",
          Coordenador = "Chiarelli",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-20).AddHours(-9),
          Objeto = "Alvorada",
          DP = "Taguatinga",
          Coordenador = "Rayssa",
          QtdEquipe = 1,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-20).AddHours(-10),
          Objeto = "Delta",
          DP = "DFP",
          Coordenador = "Benevides",
          QtdEquipe = 3,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-28).AddHours(-1),
          Objeto = "Apoio",
          DP = "10ª DP",
          Coordenador = "Higor",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-28).AddHours(-2),
          Objeto = "Delta",
          DP = "1ª DP",
          Coordenador = "Arana",
          QtdEquipe = 2,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-28).AddHours(-3),
          Objeto = "Segurança Orgânica",
          DP = "6ª DP",
          Coordenador = "Medina",
          QtdEquipe = 4,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-28).AddHours(-4),
          Objeto = "Alvorada",
          DP = "12ª DP",
          Coordenador = "Wanderson",
          QtdEquipe = 2,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-28).AddHours(-5),
          Objeto = "Apoio",
          DP = "8ª DP",
          Coordenador = "Nogueira",
          QtdEquipe = 1,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-28).AddHours(-6),
          Objeto = "Delta",
          DP = "14ª DP",
          Coordenador = "Cassis",
          QtdEquipe = 3,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-28).AddHours(-7),
          Objeto = "Segurança Orgânica",
          DP = "Ceilândia",
          Coordenador = "Sidney",
          QtdEquipe = 2,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-28).AddHours(-8),
          Objeto = "Alvorada",
          DP = "Planaltina",
          Coordenador = "Chiarelli",
          QtdEquipe = 4,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-28).AddHours(-9),
          Objeto = "Apoio",
          DP = "Taguatinga",
          Coordenador = "Rayssa",
          QtdEquipe = 1,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddDays(-28).AddHours(-10),
          Objeto = "Delta",
          DP = "DFP",
          Coordenador = "Lebrão",
          QtdEquipe = 3,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-1),
          Objeto = "Apoio",
          DP = "2ª DP",
          Coordenador = "Higor",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-2),
          Objeto = "Delta",
          DP = "5ª DP",
          Coordenador = "Arana",
          QtdEquipe = 1,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-3),
          Objeto = "Segurança Orgânica",
          DP = "10ª DP",
          Coordenador = "Medina",
          QtdEquipe = 2,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-4),
          Objeto = "Alvorada",
          DP = "12ª DP",
          Coordenador = "Sidney",
          QtdEquipe = 4,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-5),
          Objeto = "Apoio",
          DP = "6ª DP",
          Coordenador = "Rayssa",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-6),
          Objeto = "Delta",
          DP = "Ceilândia",
          Coordenador = "Wanderson",
          QtdEquipe = 2,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-7),
          Objeto = "Segurança Orgânica",
          DP = "TJDFT",
          Coordenador = "Nogueira",
          QtdEquipe = 4,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-8),
          Objeto = "Alvorada",
          DP = "Planaltina",
          Coordenador = "Cassis",
          QtdEquipe = 1,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-9),
          Objeto = "Apoio",
          DP = "Taguatinga",
          Coordenador = "Sidartha",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-10),
          Objeto = "Delta",
          DP = "DFP",
          Coordenador = "Lebrão",
          QtdEquipe = 2,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-11),
          Objeto = "Segurança Orgânica",
          DP = "20ª DP",
          Coordenador = "Medina",
          QtdEquipe = 4,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-12),
          Objeto = "Apoio",
          DP = "1ª DP",
          Coordenador = "Chiarelli",
          QtdEquipe = 3,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-13),
          Objeto = "Delta",
          DP = "14ª DP",
          Coordenador = "Rayssa",
          QtdEquipe = 1,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-14),
          Objeto = "Alvorada",
          DP = "19ª DP",
          Coordenador = "Higor",
          QtdEquipe = 2,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-1).AddHours(-15),
          Objeto = "Segurança Orgânica",
          DP = "5ª DP",
          Coordenador = "Arana",
          QtdEquipe = 4,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-1),
          Objeto = "Apoio",
          DP = "10ª DP",
          Coordenador = "Nogueira",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-2),
          Objeto = "Delta",
          DP = "8ª DP",
          Coordenador = "Higor",
          QtdEquipe = 3,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-3),
          Objeto = "Segurança Orgânica",
          DP = "14ª DP",
          Coordenador = "Medina",
          QtdEquipe = 1,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-4),
          Objeto = "Alvorada",
          DP = "TJDFT",
          Coordenador = "Cassis",
          QtdEquipe = 3,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-5),
          Objeto = "Apoio",
          DP = "Ceilândia",
          Coordenador = "Wanderson",
          QtdEquipe = 4,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-6),
          Objeto = "Delta",
          DP = "Taguatinga",
          Coordenador = "Rayssa",
          QtdEquipe = 2,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-7),
          Objeto = "Segurança Orgânica",
          DP = "1ª DP",
          Coordenador = "Sidney",
          QtdEquipe = 1,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-8),
          Objeto = "Alvorada",
          DP = "Planaltina",
          Coordenador = "Lebrão",
          QtdEquipe = 3,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-9),
          Objeto = "Apoio",
          DP = "5ª DP",
          Coordenador = "Nogueira",
          QtdEquipe = 2,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-10),
          Objeto = "Delta",
          DP = "DFP",
          Coordenador = "Arana",
          QtdEquipe = 4,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-11),
          Objeto = "Segurança Orgânica",
          DP = "20ª DP",
          Coordenador = "Medina",
          QtdEquipe = 3,
          TipoOperacaoID = 4
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-12),
          Objeto = "Apoio",
          DP = "12ª DP",
          Coordenador = "Wanderson",
          QtdEquipe = 1,
          TipoOperacaoID = 1
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-13),
          Objeto = "Alvorada",
          DP = "19ª DP",
          Coordenador = "Cassis",
          QtdEquipe = 2,
          TipoOperacaoID = 2
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-14),
          Objeto = "Delta",
          DP = "8ª DP",
          Coordenador = "Sidney",
          QtdEquipe = 3,
          TipoOperacaoID = 3
        },
        new Operacao
        {
          DataHora = DateTime.Now.AddMonths(-2).AddHours(-15),
          Objeto = "Segurança Orgânica",
          DP = "10ª DP",
          Coordenador = "Chiarelli",
          QtdEquipe = 4,
          TipoOperacaoID = 4
        },

      };


      _operacaoAppService.AddRange(operacoes);
    }

    protected override void Kill()
    {
      _operacaoAppService.GetAll().ToList().ForEach(op => _operacaoAppService.Remove(op));
    }
  }
}
