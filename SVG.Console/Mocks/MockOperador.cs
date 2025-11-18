using SVG.App.Interface;
using SVG.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Console.Mocks
{
  public class MockOperador
  {
    private readonly IOperadorAppService _operadorAppService;
    private List<Operador> _operadoresMock;

    public MockOperador(IOperadorAppService operadorAppService)
    {
      _operadorAppService = operadorAppService;

      Kill();
      Seed();
    }

    public void Seed()
    {
      GerarOperadores();
      _operadorAppService.AddRange(_operadoresMock);
    }

    public void Kill()
    {
      _operadorAppService.GetAll().ToList().ForEach(op => _operadorAppService.Remove(op));
    }

    private void GerarOperadores()
    {

      _operadoresMock =
      #region 
        new List<Operador>
            {
                // SOE I (1)
                new Operador { Nome = "Adriano Viana Batista", Matricula = "78.131-2", Telefone = "98112-8520", SessaoID = 1 },
                new Operador { Nome = "Anderson Benevides Valencia", Matricula = "235.295-8", Telefone = "98371-2442", SessaoID = 1 },
                new Operador { Nome = "André Ricardo Oliveira Marinho", Matricula = "57.809-6", Telefone = "99333-2109", SessaoID = 1 },
                new Operador { Nome = "Bruno Lima Aguirra", Matricula = "188.413-1", Telefone = "98102-6325", SessaoID = 1 },
                new Operador { Nome = "Cleuber Medeiros Guimarães", Matricula = "78.393-5", Telefone = "98300-0809", SessaoID = 1 },

                // SOE II (2)
                new Operador { Nome = "Cristiano Jardim de Gusmão", Matricula = "57.462-7", Telefone = "99868-4391", SessaoID = 2 },
                new Operador { Nome = "Cristiano Pereira de Jesus", Matricula = "235.212-5", Telefone = "99417-7778", SessaoID = 2 },
                new Operador { Nome = "Daniel Lebrão Arruda", Matricula = "57.600-X", Telefone = "98480-4550", SessaoID = 2 },
                new Operador { Nome = "Danilo Ricardo de Paiva Cunha", Matricula = "227.740-9", Telefone = "99684-3553", SessaoID = 2 },
                new Operador { Nome = "Diego Madureira Rodrigues", Matricula = "186.000-3", Telefone = "98143-1940", SessaoID = 2 },

                // SOE III (3)
                new Operador { Nome = "Edson Medina de Oliveira", Matricula = "89.260-2", Telefone = "98132-8773", SessaoID = 3 },
                new Operador { Nome = "Eduardo Cosme Carvalho da Silva", Matricula = "76.826-X", Telefone = "98134-4918", SessaoID = 3 },
                new Operador { Nome = "Felipe Chiarelli Linhares Titoneli", Matricula = "1.721.534-X", Telefone = "22-99267-9153", SessaoID = 3 },
                new Operador { Nome = "Felipe Sousa Farias", Matricula = "228.226-7", Telefone = "99139-6265", SessaoID = 3 },

                // SOE IV (4)
                new Operador { Nome = "Francisco Lanna Guillén", Matricula = "57.540-2", Telefone = "98642-3185", SessaoID = 4 },
                new Operador { Nome = "Frantihesco Lauriel Fernandes Nunes", Matricula = "235.271-0", Telefone = "98642-3185", SessaoID = 4 },
                new Operador { Nome = "Frank Rodrigues Ferreira", Matricula = "236.616-9", Telefone = "98134-6967", SessaoID = 4 },

                // SOR (5)
                new Operador { Nome = "Gabriel Arana da Silva", Matricula = "1.721.229-4", Telefone = "98232-4991", SessaoID = 5 },
                new Operador { Nome = "Geovane Ribeiro Mathias", Matricula = "228.395-6", Telefone = "98322-5544", SessaoID = 5 },
                new Operador { Nome = "Higor Barbosa de Souza", Matricula = "1.721.222-7", Telefone = "98666-5241", SessaoID = 5 },

                // SOT (6)
                new Operador { Nome = "Honney Cordeiro", Matricula = "57.764-2", Telefone = "98111-7629", SessaoID = 6 },
                new Operador { Nome = "Hugo Leonardo Garcia Ferreira", Matricula = "234.273-1", Telefone = "6299967-2400", SessaoID = 6 },
                new Operador { Nome = "Igor Thiago Maux Lopes", Matricula = "1.716.352-8", Telefone = "98242-8640", SessaoID = 6 },

                // SI (7)
                new Operador { Nome = "Jorge Vinicius Moura Campos", Matricula = "236.047-0", Telefone = "98442-1776", SessaoID = 7 },
                new Operador { Nome = "Josué Carvalho da Costa", Matricula = "236.637-1", Telefone = "98605-0909", SessaoID = 7 },
                new Operador { Nome = "Juliano Dantas Bueno", Matricula = "225-345-3", Telefone = "98127-4841", SessaoID = 7 },

                // SOC (8)
                new Operador { Nome = "Kennedy Ben Oliveira Primo", Matricula = "230.301-9", Telefone = "99886-1706", SessaoID = 8 },
                new Operador { Nome = "Klebson Alves Fonseca", Matricula = "227.929-0", Telefone = "99806-1982", SessaoID = 8 },
                new Operador { Nome = "Luiz Cesar Mendes de Almeida", Matricula = "231.066-X", Telefone = "99859-9845", SessaoID = 8 },

                // GAB (9)
                new Operador { Nome = "Maiquel Anderson Cavalcante Mendes", Matricula = "59.270-6", Telefone = "98423-0609", SessaoID = 9 },
                new Operador { Nome = "Marcello Bentes C. de Albuquerque", Matricula = "188.544-8", Telefone = "98118-0755", SessaoID = 9 },
                new Operador { Nome = "Marcelo Nunes", Matricula = "235.228-1", Telefone = "99800-3044", SessaoID = 9 },
                new Operador { Nome = "Marcelo Thomas", Matricula = "57.720-0", Telefone = "99629-0110", SessaoID = 9 },
                new Operador { Nome = "Marcio Romeiro Pereira Júnior", Matricula = "192.552-0", Telefone = "98642-6642", SessaoID = 9 },
                new Operador { Nome = "Marcio Roberto Valente Caetano", Matricula = "58.436-3", Telefone = "99121-9000", SessaoID = 9 },
                new Operador { Nome = "Maurício Victor Cassis", Matricula = "231.443-4", Telefone = "98372-8684", SessaoID = 9 },
                new Operador { Nome = "Marcos Davila Teixeira", Matricula = "189.289-4", Telefone = "99662-7891", SessaoID = 9 },
                new Operador { Nome = "Paulo Roberto Tavares Brandão", Matricula = "76.224-5", Telefone = "98317-5901", SessaoID = 9 },
                new Operador { Nome = "Pedro Henrique Duarte M. Brito", Matricula = "1.719.773-2", Telefone = "98530-0763", SessaoID = 9 },
                new Operador { Nome = "Rafaela Lopes Andrade", Matricula = "233.692-8", Telefone = "98182-4282", SessaoID = 9 },
                new Operador { Nome = "Raphael Rodolfo Torres Gaia", Matricula = "236.647-9", Telefone = "99876-1089", SessaoID = 9 },
                new Operador { Nome = "Rayssa Polianna Silva", Matricula = "1.716.352-8", Telefone = "98242-8640", SessaoID = 9 },
                new Operador { Nome = "Renato Bizinoto Molás", Matricula = "227.855-3", Telefone = "98492-4391", SessaoID = 9 },
                new Operador { Nome = "Rubens Torres Deolindo", Matricula = "75.812-4", Telefone = "99966-3080", SessaoID = 9 },
                new Operador { Nome = "Santilheno Marcos da Silva", Matricula = "233.672-3", Telefone = "98332-2357", SessaoID = 9 },
                new Operador { Nome = "Sidartha Souza de Quevedo", Matricula = "238.906-1", Telefone = "98443-1050", SessaoID = 9 },
                new Operador { Nome = "Sidney da Silva de Oliveira", Matricula = "1.721.929-9", Telefone = "48-9857-7150", SessaoID = 9 },
                new Operador { Nome = "Thallys Mendes Passos", Matricula = "77.369-7", Telefone = "99824-9363", SessaoID = 9 },
                new Operador { Nome = "Vanderlei Ferreira Dutra", Matricula = "57.682-4", Telefone = "99104-9583", SessaoID = 9 },
                new Operador { Nome = "Vinicius Gomes dos Santos Fontes", Matricula = "229.161-4", Telefone = "98260-0960", SessaoID = 9 },
                new Operador { Nome = "Wagner Alves Gonçalves Nogueira", Matricula = "1.721.321-5", Telefone = "62-99373-1723", SessaoID = 9 },
                new Operador { Nome = "Wanderson Gomes dos Santos", Matricula = "1.721.621-5", Telefone = "79-99104-6399", SessaoID = 9 }
            };
      #endregion
    }
  }
}
