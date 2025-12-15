namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512131100 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        SET IDENTITY_INSERT [dbo].[Operador] ON 
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (130, N'89.260-2', N'Edson Medina de Oliveira', NULL, 9, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (131, N'76.224-5', N'Paulo Roberto Tavares Brandão', NULL, 9, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (132, N'77.545-2', N'Leandro de Oliveira Sampaio', NULL, 9, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (133, N'58.418-5', N'Marcelo Vieira de Sousa', NULL, 9, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (134, N'59.039-8', N'Gustavo Amaral Yung', NULL, 9, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (135, N'192.112-6', N'Igor Thiago Maux Lopes', NULL, 7, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (136, N'59.270-6', N'Maiquel A. Cavalcante Mendes', NULL, 7, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (137, N'35.381-7', N'Silvestre Milhomem Amaral', NULL, 7, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (138, N'36.007-4', N'Adenauer Dantas Justo', NULL, 7, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (139, N'57.752-9', N'Roberto Jean Philippe Corrêa', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (140, N'228.395-6', N'Geovane Ribeiro Mathias', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (141, N'78.837-6', N'Vicente Cezar Ferreira Junior', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (142, N'228.226-7', N'Felipe Sousa Farias', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (143, N'230.856-8', N'Marcelo Vasconcelos Dias', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (144, N'231.033-3', N'Bruno Alves Bezerra Silva', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (145, N'231.046-5', N'Alvaro H. M. da Silva Santos', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (146, N'231.443-6', N'Mauricio Victor Cassis', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (147, N'233.672-3', N'Santilhento Marcos da Silva', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (148, N'236.647-9', N'Raphael Rodolfo Torres Gaia', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (149, N'1.716.352-8', N'Rayssa Polianna Silva', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (150, N'1.721.321-5', N'Wagner Alves Gonçalves Nogueira', NULL, 5, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (151, N'230.301-9', N'Kennedy Ben Oliveira Primo', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (152, N'235.205-2', N'Daniel Beltrame Faria', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (153, N'76.685-2', N'Daniel M. de L. e Alvarenga Peixoto', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (154, N'225.345-3', N'Juliano Dantas Bueno', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (155, N'227.740-9', N'Danilo Ricardo de Paiva Cunha', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (156, N'227.888-X', N'Pericles M. de Rezende Junior', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (157, N'234.273-1', N'Hugo Leonardo Garcia Ferreira', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (158, N'235.228-1', N'Marcelo Nunes', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (159, N'236.130-2', N'Tiago Resende Brant', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (160, N'236.616-9', N'Frank Rodrigues Ferreira', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (161, N'1.721.534-X', N'Felipe Chiarelli Linhares Titoneli', NULL, 6, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (162, N'58.160-7', N'Sanlac Machado da Cunha', NULL, 8, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (163, N'236.639-8', N'Cinthia Versiani Pontes', NULL, 8, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (164, N'78.131-2', N'Adriano Viano Batista', NULL, 8, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (165, N'227.617-8', N'Ricardo Santos Textor', NULL, 8, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (166, N'227.631-3', N'Pablo Samora Bonifácio Medeiros', NULL, 8, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (167, N'229.161-4', N'Vinicius Gomes dos Santos Fontes', NULL, 8, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (168, N'233.692-8', N'Rafaela Lopes Andrade', NULL, 8, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (169, N'236.058-6', N'Aurelio Gleria Cavalcante', NULL, 8, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (170, N'227.855-3', N'Renato Bizinoto Molas', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (171, N'186.000-3', N'Diego Madureira Rodrigues', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (172, N'47.496-7', N'Silvio Cesar Crelier da Silva', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (173, N'57.720-0', N'Marcelo Thomas', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (174, N'76.826-X', N'Eduardo Cosme Carvalho da Silva', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (175, N'188.479-4', N'Pedro Rollemberg Mollo', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (176, N'188.544-8', N'Marcello Bentes C. Albuquerque', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (177, N'236.637-1', N'Josué Carvalho da Costa', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (178, N'236.650-9', N'Luis Ricardo Brasilino', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (179, N'238.906-1', N'Sidartha Souza de Quevedo', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (180, N'1.721.222-7', N'Higor Barbosa de Souza', NULL, 1, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (181, N'57.764-2', N'Honney Cordeiro', NULL, 2, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (182, N'77.369-7', N'Thallys Mendes Passos', NULL, 2, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (183, N'57.540-2', N'Francisco Lanna Guillen', NULL, 2, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (184, N'57.682-4', N'Vanderlei Ferreira Dutra', NULL, 2, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (185, N'233.676-6', N'Alberto Ganzaroli Neto', NULL, 2, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (186, N'235.212-5', N'Cristiano Pereira de Jesus', NULL, 2, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (187, N'236.047-0', N'Jorge Vinicius Moura Campos', NULL, 2, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (188, N'1.721.929-9', N'Sidney da Silva de Oliveira', NULL, 2, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (189, N'231.066-X', N'Luiz Cesar Mendes de Almeida', NULL, 3, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (190, N'227.929-0', N'Klebson Alves Fonseca', NULL, 3, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (191, N'57.923-8', N'Fabio Silva Piazzarollo', NULL, 3, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (192, N'75.812-4', N'Rubens Torres Deolindo', NULL, 3, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (193, N'78.393-5', N'Cleuber Medeiros Guimarães', NULL, 3, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (194, N'235.271-0', N'Franthiesco L. Fernandes Nunes', NULL, 3, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (195, N'1.719.773-2', N'Pedro H. Duarte Medeiros de Brito', NULL, 3, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (196, N'1.721.229-4', N'Gabriel Arana da Silva', NULL, 3, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (197, N'1.721.612-5', N'Wanderson Gomes dos Santos', NULL, 3, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (198, N'57.462-7', N'Cristiano Jardim de Gusmão', NULL, 4, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (199, N'57.809-6', N'Andre Ricardo Oliveira Marinho', NULL, 4, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (200, N'47.567-X', N'Lincon Massahiro Takano', NULL, 4, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (201, N'57.600-X', N'Daniel Lebrão Arruda', NULL, 4, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (202, N'188.413-1', N'Bruno Lima Aguirra', NULL, 4, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (203, N'189.289-4', N'Marcos Davila Teixeira', NULL, 4, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (204, N'192.552-0', N'Marcio Romeiro Pereira Junior', NULL, 4, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (205, N'235.295-8', N'Anderson Benevides Valença', NULL, 4, NULL)
        INSERT [dbo].[Operador] ([ID], [Matricula], [Nome], [Telefone], [SessaoID], [Alcunha]) VALUES (206, N'58.436-3', N'Marcio Roberto Valente Caetano', NULL, 4, NULL)
        SET IDENTITY_INSERT [dbo].[Operador] OFF

      ");

      Sql(@"
          BEGIN TRAN;

          -- =========================================
          -- OPERACOES (DEZEMBRO/2025) - geradas do Excel
          -- Regra: Seguranca Organica sem data => D+1 da ultima data conhecida
          -- Horario fixo: 08:00 | SvgAberto = 0
          -- =========================================

          IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253')
          BEGIN
              INSERT INTO [dbo].[Operacao]
              (
                  [DataHora],
                  [Objeto],
                  [Coordenador],
                  [QtdEquipe],
                  [TipoOperacaoID],
                  [DataHoraCriacao],
                  [SvgAberto],
                  [OrdemServico]
              )
              VALUES
              (
                  '2025-12-04T08:00:00',
                  'Apoio à P12',
                  NULL,
                  11,
                  1,
                  '2025-12-04T08:00:00',
                  0,
                  'OS 253'
              );
          END

          IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 252')
          BEGIN
              INSERT INTO [dbo].[Operacao]
              (
                  [DataHora],
                  [Objeto],
                  [Coordenador],
                  [QtdEquipe],
                  [TipoOperacaoID],
                  [DataHoraCriacao],
                  [SvgAberto],
                  [OrdemServico]
              )
              VALUES
              (
                  '2025-12-05T08:00:00',
                  'Reforço da Segurança Orgânica',
                  NULL,
                  3,
                  4,
                  '2025-12-05T08:00:00',
                  0,
                  'OS 252'
              );
          END

          IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254')
          BEGIN
              INSERT INTO [dbo].[Operacao]
              (
                  [DataHora],
                  [Objeto],
                  [Coordenador],
                  [QtdEquipe],
                  [TipoOperacaoID],
                  [DataHoraCriacao],
                  [SvgAberto],
                  [OrdemServico]
              )
              VALUES
              (
                  '2025-12-08T08:00:00',
                  'Apoio à P8',
                  NULL,
                  22,
                  1,
                  '2025-12-08T08:00:00',
                  0,
                  'OS 254'
              );
          END

          -- =========================================
          -- OPERADOR x OPERACAO (DEZEMBRO/2025)
          -- Regra especial: 'SI PAKATO' => OperadorID = 135 (Igor Thiago Maux Lopes)
          -- SVG = 0 para todos
          -- =========================================

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 160
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  160,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 157
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  157,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 158
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  158,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 156
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  156,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 252'
                AND oo.OperadorID = 132
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 252' ORDER BY ID DESC),
                  132,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 135
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  135,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 136
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  136,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 150
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  150,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 177
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  177,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 179
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  179,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 252'
                AND oo.OperadorID = 179
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 252' ORDER BY ID DESC),
                  179,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 178
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  178,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 182
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  182,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 184
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  184,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 252'
                AND oo.OperadorID = 188
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 252' ORDER BY ID DESC),
                  188,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 189
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  189,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 191
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  191,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 192
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  192,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 194
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  194,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 195
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  195,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 195
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  195,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 196
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  196,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 198
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  198,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 198
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  198,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 206
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  206,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 201
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  201,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 201
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  201,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 205
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  205,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 200
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  200,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 200
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  200,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 162
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  162,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 162
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  162,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 167
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  167,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 253'
                AND oo.OperadorID = 166
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 253' ORDER BY ID DESC),
                  166,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 164
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  164,
                  0
              );
          END

          IF NOT EXISTS (
              SELECT 1
              FROM [dbo].[OperadorOperacao] oo
              JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
              WHERE o.[OrdemServico] = 'OS 254'
                AND oo.OperadorID = 168
          )
          BEGIN
              INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
              VALUES (
                  (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 254' ORDER BY ID DESC),
                  168,
                  0
              );
          END

          COMMIT;

      ");

    }

    public override void Down()
    {
    }
  }
}
