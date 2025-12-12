namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512091850 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        -- =========================
        -- GABINETE (SessaoID = 9)
        -- =========================
        INSERT INTO [dbo].[Operador] (Matricula, Nome, Telefone, SessaoID) VALUES
        ('89.260-2', 'Edson Medina de Oliveira', NULL, 9),
        ('76.224-5', 'Paulo Roberto Tavares Brandão', NULL, 9),
        ('77.545-2', 'Leandro de Oliveira Sampaio', NULL, 9),
        ('58.418-5', 'Marcelo Vieira de Sousa', NULL, 9),
        ('59.039-8', 'Gustavo Amaral Yung', NULL, 9);

        -- =========================
        -- SEÇÃO DE INSTRUÇÃO (SI = 7)
        -- =========================
        INSERT INTO [dbo].[Operador] (Matricula, Nome, Telefone, SessaoID) VALUES
        ('192.112-6', 'Igor Thiago Maux Lopes', NULL, 7),
        ('59.270-6', 'Maiquel A. Cavalcante Mendes', NULL, 7),
        ('35.381-7', 'Silvestre Milhomem Amaral', NULL, 7),
        ('36.007-4', 'Adenauer Dantas Justo', NULL, 7);

        -- =========================
        -- SEÇÃO DE OPERAÇÕES E RESGATE (SOR = 5)
        -- =========================
        INSERT INTO [dbo].[Operador] (Matricula, Nome, Telefone, SessaoID) VALUES
        ('57.752-9', 'Roberto Jean Philippe Corrêa', NULL, 5),
        ('228.395-6', 'Geovane Ribeiro Mathias', NULL, 5),
        ('78.837-6', 'Vicente Cezar Ferreira Junior', NULL, 5),
        ('228.226-7', 'Felipe Sousa Farias', NULL, 5),
        ('230.856-8', 'Marcelo Vasconcelos Dias', NULL, 5),
        ('231.033-3', 'Bruno Alves Bezerra Silva', NULL, 5),
        ('231.046-5', 'Alvaro H. M. da Silva Santos', NULL, 5),
        ('231.443-6', 'Mauricio Victor Cassis', NULL, 5),
        ('233.672-3', 'Santilhento Marcos da Silva', NULL, 5),
        ('236.647-9', 'Raphael Rodolfo Torres Gaia', NULL, 5),
        ('1.716.352-8', 'Rayssa Polianna Silva', NULL, 5),
        ('1.721.321-5', 'Wagner Alves Gonçalves Nogueira', NULL, 5);

        -- =========================
        -- SEÇÃO DE OPERAÇÕES TÁTICAS (SOT = 6)
        -- =========================
        INSERT INTO [dbo].[Operador] (Matricula, Nome, Telefone, SessaoID) VALUES
        ('230.301-9', 'Kennedy Ben Oliveira Primo', NULL, 6),
        ('235.205-2', 'Daniel Beltrame Faria', NULL, 6),
        ('76.685-2', 'Daniel M. de L. e Alvarenga Peixoto', NULL, 6),
        ('225.345-3', 'Juliano Dantas Bueno', NULL, 6),
        ('227.740-9', 'Danilo Ricardo de Paiva Cunha', NULL, 6),
        ('227.888-X', 'Pericles M. de Rezende Junior', NULL, 6),
        ('234.273-1', 'Hugo Leonardo Garcia Ferreira', NULL, 6),
        ('235.228-1', 'Marcelo Nunes', NULL, 6),
        ('236.130-2', 'Tiago Resende Brant', NULL, 6),
        ('236.616-9', 'Frank Rodrigues Ferreira', NULL, 6),
        ('1.721.534-X', 'Felipe Chiarelli Linhares Titoneli', NULL, 6);

        -- =========================
        -- SEÇÃO DE OPERAÇÕES COM CÃES (SOC = 8)
        -- =========================
        INSERT INTO [dbo].[Operador] (Matricula, Nome, Telefone, SessaoID) VALUES
        ('58.160-7', 'Sanlac Machado da Cunha', NULL, 8),
        ('236.639-8', 'Cinthia Versiani Pontes', NULL, 8),
        ('78.131-2', 'Adriano Viano Batista', NULL, 8),
        ('227.617-8', 'Ricardo Santos Textor', NULL, 8),
        ('227.631-3', 'Pablo Samora Bonifácio Medeiros', NULL, 8),
        ('229.161-4', 'Vinicius Gomes dos Santos Fontes', NULL, 8),
        ('233.692-8', 'Rafaela Lopes Andrade', NULL, 8),
        ('236.058-6', 'Aurelio Gleria Cavalcante', NULL, 8);

        -- =========================
        -- SOE I (SessaoID = 1)
        -- =========================
        INSERT INTO [dbo].[Operador] (Matricula, Nome, Telefone, SessaoID) VALUES
        ('227.855-3', 'Renato Bizinoto Molas', NULL, 1),
        ('186.000-3', 'Diego Madureira Rodrigues', NULL, 1),
        ('47.496-7', 'Silvio Cesar Crelier da Silva', NULL, 1),
        ('57.720-0', 'Marcelo Thomas', NULL, 1),
        ('76.826-X', 'Eduardo Cosme Carvalho da Silva', NULL, 1),
        ('188.479-4', 'Pedro Rollemberg Mollo', NULL, 1),
        ('188.544-8', 'Marcello Bentes C. Albuquerque', NULL, 1),
        ('236.637-1', 'Josué Carvalho da Costa', NULL, 1),
        ('236.650-9', 'Luis Ricardo Brasilino', NULL, 1),
        ('238.906-1', 'Sidartha Souza de Quevedo', NULL, 1),
        ('1.721.222-7', 'Higor Barbosa de Souza', NULL, 1);

        -- =========================
        -- SOE II (SessaoID = 2)
        -- =========================
        INSERT INTO [dbo].[Operador] (Matricula, Nome, Telefone, SessaoID) VALUES
        ('57.764-2', 'Honney Cordeiro', NULL, 2),
        ('77.369-7', 'Thallys Mendes Passos', NULL, 2),
        ('57.540-2', 'Francisco Lanna Guillen', NULL, 2),
        ('57.682-4', 'Vanderlei Ferreira Dutra', NULL, 2),
        ('233.676-6', 'Alberto Ganzaroli Neto', NULL, 2),
        ('235.212-5', 'Cristiano Pereira de Jesus', NULL, 2),
        ('236.047-0', 'Jorge Vinicius Moura Campos', NULL, 2),
        ('1.721.929-9', 'Sidney da Silva de Oliveira', NULL, 2);

        -- =========================
        -- SOE III (SessaoID = 3)
        -- =========================
        INSERT INTO [dbo].[Operador] (Matricula, Nome, Telefone, SessaoID) VALUES
        ('231.066-X', 'Luiz Cesar Mendes de Almeida', NULL, 3),
        ('227.929-0', 'Klebson Alves Fonseca', NULL, 3),
        ('57.923-8', 'Fabio Silva Piazzarollo', NULL, 3),
        ('75.812-4', 'Rubens Torres Deolindo', NULL, 3),
        ('78.393-5', 'Cleuber Medeiros Guimarães', NULL, 3),
        ('235.271-0', 'Franthiesco L. Fernandes Nunes', NULL, 3),
        ('1.719.773-2', 'Pedro H. Duarte Medeiros de Brito', NULL, 3),
        ('1.721.229-4', 'Gabriel Arana da Silva', NULL, 3),
        ('1.721.612-5', 'Wanderson Gomes dos Santos', NULL, 3);

        -- =========================
        -- SOE IV (SessaoID = 4)
        -- =========================
        INSERT INTO [dbo].[Operador] (Matricula, Nome, Telefone, SessaoID) VALUES
        ('57.462-7', 'Cristiano Jardim de Gusmão', NULL, 4),
        ('57.809-6', 'Andre Ricardo Oliveira Marinho', NULL, 4),
        ('47.567-X', 'Lincon Massahiro Takano', NULL, 4),
        ('57.600-X', 'Daniel Lebrão Arruda', NULL, 4),
        ('188.413-1', 'Bruno Lima Aguirra', NULL, 4),
        ('189.289-4', 'Marcos Davila Teixeira', NULL, 4),
        ('192.552-0', 'Marcio Romeiro Pereira Junior', NULL, 4),
        ('235.295-8', 'Anderson Benevides Valença', NULL, 4),
        ('58.436-3', 'Marcio Roberto Valente Caetano', NULL, 4);

      ");


    }

    public override void Down()
    {
    }
  }
}
