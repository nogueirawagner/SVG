using SVG.App.Interface;
using SVG.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Console
{
  public class MockOperador
  {
    private readonly IOperadorAppService _operadorAppService;
    private List<Operador> _operadoresMock;

    public MockOperador(IOperadorAppService operadorAppService)
    {
      _operadorAppService = operadorAppService;

      _operadoresMock = new List<Operador>
      {
        #region 
        new Operador { Matricula = "1001", Nome = "Wagner Nogueira", Sessao = "SOE I" },
          new Operador { Matricula = "1002", Nome = "Higor Almeida", Sessao = "SOE II" },
          new Operador { Matricula = "1003", Nome = "Arana Silva", Sessao = "SOE III" },
          new Operador { Matricula = "1004", Nome = "Wanderson Costa", Sessao = "SOE IV" },
          new Operador { Matricula = "1005", Nome = "Benevides Rocha", Sessao = "SOR" },
          new Operador { Matricula = "1006", Nome = "Rayssa Martins", Sessao = "SOT" },
          new Operador { Matricula = "1007", Nome = "Sidney Barros", Sessao = "SI" },
          new Operador { Matricula = "1008", Nome = "Pedro Chaves", Sessao = "SOE I" },
          new Operador { Matricula = "1009", Nome = "Chiarelli Sousa", Sessao = "SOE II" },
          new Operador { Matricula = "1010", Nome = "Cassis Ribeiro", Sessao = "SOE III" },
          new Operador { Matricula = "1011", Nome = "Danilo Freitas", Sessao = "SOE IV" },
          new Operador { Matricula = "1012", Nome = "Daniel Matheus", Sessao = "SOR" },
          new Operador { Matricula = "1013", Nome = "Sidartha Lima", Sessao = "SOT" },
          new Operador { Matricula = "1014", Nome = "Brant Moreira", Sessao = "SI" },
          new Operador { Matricula = "1015", Nome = "Medina Carvalho", Sessao = "SOE I" },
          new Operador { Matricula = "1016", Nome = "Silvestre Pinto", Sessao = "SOE II" },
          new Operador { Matricula = "1017", Nome = "Hugo Fernandes", Sessao = "SOE III" },
          new Operador { Matricula = "1018", Nome = "Vicente Cézar", Sessao = "SOE IV" },
          new Operador { Matricula = "1019", Nome = "Igor Maux", Sessao = "SOR" },
          new Operador { Matricula = "1020", Nome = "Maiquel Santos", Sessao = "SOT" }
      #endregion
      };

    }

    public void AdicionarOperador()
    {
      _operadorAppService.AddRange(_operadoresMock);
    }

    public void LimparOperadores()
    {
      _operadorAppService.GetAll().ToList().ForEach(op => _operadorAppService.Remove(op));
    }
  }
}
