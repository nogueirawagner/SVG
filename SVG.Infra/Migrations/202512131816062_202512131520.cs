namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512131520 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
      BEGIN TRAN;

      -- =========================================
      -- OPERACOES (MARCO/2025) - geradas do Excel
      -- Horario fixo: 08:00 | SvgAberto = 0
      -- Regra: quando nao houver data na AE => D+1 da ultima data conhecida
      -- Regras de tipo:
      -- - Reforco de Seguranca Organica => TipoOperacaoID = 4 (Seguranca Organica)
      -- - Reforco de Plantao => TipoOperacaoID = 1 (Apoio)
      -- - Planejamento Operacional => TipoOperacaoID = 1 (Apoio)
      -- =========================================
      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46')
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
              '2025-03-07T08:00:00',
              'Reforço',
              NULL,
              12,
              4,
              '2025-03-07T08:00:00',
              0,
              'OS 46'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 48')
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
              '2025-03-07T08:00:00',
              'Reforço',
              NULL,
              12,
              4,
              '2025-03-07T08:00:00',
              0,
              'OS 48'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49')
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
              '2025-03-07T08:00:00',
              'Apoio à P8',
              NULL,
              12,
              1,
              '2025-03-07T08:00:00',
              0,
              'OS 49'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 50')
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
              '2025-03-10T08:00:00',
              'Alvorada',
              NULL,
              4,
              2,
              '2025-03-10T08:00:00',
              0,
              'OS 50'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 53')
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
              '2025-03-15T08:00:00',
              'Apoio à SSP',
              NULL,
              3,
              1,
              '2025-03-15T08:00:00',
              0,
              'OS 53'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 54')
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
              '2025-03-17T08:00:00',
              'Apoio à P16',
              NULL,
              6,
              1,
              '2025-03-17T08:00:00',
              0,
              'OS 54'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56')
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
              '2025-03-20T08:00:00',
              'Apoio à P33',
              NULL,
              13,
              1,
              '2025-03-20T08:00:00',
              0,
              'OS 56'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57')
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
              '2025-03-21T08:00:00',
              'Apoio à P12',
              NULL,
              29,
              1,
              '2025-03-21T08:00:00',
              0,
              'OS 57'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58')
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
              '2025-03-26T08:00:00',
              'Delta',
              NULL,
              22,
              3,
              '2025-03-26T08:00:00',
              0,
              'OS 58'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 59')
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
              '2025-03-26T08:00:00',
              'Alvorada',
              NULL,
              4,
              2,
              '2025-03-26T08:00:00',
              0,
              'OS 59'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 60')
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
              '2025-03-26T08:00:00',
              'Apoio à P11',
              NULL,
              6,
              1,
              '2025-03-26T08:00:00',
              0,
              'OS 60'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61')
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
              '2025-03-28T08:00:00',
              'Apoio ao DECOR',
              NULL,
              19,
              1,
              '2025-03-28T08:00:00',
              0,
              'OS 61'
          );
      END

      IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63')
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
              '2025-03-31T08:00:00',
              'DELTA',
              NULL,
              13,
              3,
              '2025-03-31T08:00:00',
              0,
              'OS 63'
          );
      END

      -- =========================================
      -- OPERADOR x OPERACAO (MARCO/2025)
      -- SVG = 0 para todos | SI PAKATO => OperadorID 135
      -- =========================================

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 131
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              131,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 151
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              151,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 151
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              151,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 152
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              152,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 159
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              159,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 160
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              160,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 160
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              160,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 60'
            AND oo.OperadorID = 160
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 60' ORDER BY ID DESC),
              160,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 160
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              160,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 46'
            AND oo.OperadorID = 187
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46' ORDER BY ID DESC),
              187,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 187
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              187,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 187
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              187,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 153
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              153,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 154
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              154,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 154
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              154,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 60'
            AND oo.OperadorID = 154
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 60' ORDER BY ID DESC),
              154,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 154
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              154,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 50'
            AND oo.OperadorID = 132
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 50' ORDER BY ID DESC),
              132,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 132
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              132,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 59'
            AND oo.OperadorID = 132
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 59' ORDER BY ID DESC),
              132,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 59'
            AND oo.OperadorID = 135
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 59' ORDER BY ID DESC),
              135,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 135
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              135,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 137
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              137,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 137
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              137,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 139
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              139,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 139
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              139,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 140
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              140,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 140
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              140,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 46'
            AND oo.OperadorID = 141
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46' ORDER BY ID DESC),
              141,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 141
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              141,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 141
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              141,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 141
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              141,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 141
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              141,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 60'
            AND oo.OperadorID = 141
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 60' ORDER BY ID DESC),
              141,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 141
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              141,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 141
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              141,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 142
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              142,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 142
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              142,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 142
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              142,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 143
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              143,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 143
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              143,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 143
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              143,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 143
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              143,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 143
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              143,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 145
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              145,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 145
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              145,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 146
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              146,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 146
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              146,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 59'
            AND oo.OperadorID = 146
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 59' ORDER BY ID DESC),
              146,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 146
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              146,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 46'
            AND oo.OperadorID = 147
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46' ORDER BY ID DESC),
              147,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 147
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              147,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 147
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              147,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 148
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              148,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 148
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              148,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 148
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              148,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 170
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              170,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 170
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              170,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 46'
            AND oo.OperadorID = 173
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46' ORDER BY ID DESC),
              173,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 48'
            AND oo.OperadorID = 173
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 48' ORDER BY ID DESC),
              173,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 173
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              173,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 173
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              173,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 48'
            AND oo.OperadorID = 174
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 48' ORDER BY ID DESC),
              174,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 174
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              174,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 177
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              177,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 177
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              177,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 177
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              177,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 46'
            AND oo.OperadorID = 181
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46' ORDER BY ID DESC),
              181,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 48'
            AND oo.OperadorID = 181
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 48' ORDER BY ID DESC),
              181,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 181
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              181,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 181
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              181,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 60'
            AND oo.OperadorID = 181
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 60' ORDER BY ID DESC),
              181,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 181
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              181,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 181
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              181,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 182
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              182,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 182
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              182,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 46'
            AND oo.OperadorID = 184
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46' ORDER BY ID DESC),
              184,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 184
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              184,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 184
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              184,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 184
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              184,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 60'
            AND oo.OperadorID = 184
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 60' ORDER BY ID DESC),
              184,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 184
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              184,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 183
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              183,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 185
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              185,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 46'
            AND oo.OperadorID = 186
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46' ORDER BY ID DESC),
              186,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 48'
            AND oo.OperadorID = 186
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 48' ORDER BY ID DESC),
              186,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 186
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              186,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 186
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              186,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 186
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              186,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 60'
            AND oo.OperadorID = 186
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 60' ORDER BY ID DESC),
              186,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 186
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              186,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 46'
            AND oo.OperadorID = 158
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46' ORDER BY ID DESC),
              158,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 158
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              158,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 158
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              158,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 157
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              157,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 157
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              157,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 157
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              157,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 157
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              157,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 46'
            AND oo.OperadorID = 189
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46' ORDER BY ID DESC),
              189,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 50'
            AND oo.OperadorID = 189
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 50' ORDER BY ID DESC),
              189,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 189
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              189,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 189
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              189,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 59'
            AND oo.OperadorID = 189
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 59' ORDER BY ID DESC),
              189,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 190
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              190,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 191
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              191,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 191
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              191,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 50'
            AND oo.OperadorID = 193
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 50' ORDER BY ID DESC),
              193,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 193
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              193,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 50'
            AND oo.OperadorID = 156
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 50' ORDER BY ID DESC),
              156,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 156
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              156,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 46'
            AND oo.OperadorID = 198
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 46' ORDER BY ID DESC),
              198,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 198
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              198,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 198
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              198,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 198
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              198,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 199
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              199,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 199
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              199,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 49'
            AND oo.OperadorID = 206
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 49' ORDER BY ID DESC),
              206,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 206
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              206,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 206
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              206,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 63'
            AND oo.OperadorID = 201
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 63' ORDER BY ID DESC),
              201,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 202
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              202,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 58'
            AND oo.OperadorID = 204
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 58' ORDER BY ID DESC),
              204,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 204
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              204,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 54'
            AND oo.OperadorID = 162
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 54' ORDER BY ID DESC),
              162,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 162
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              162,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 162
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              162,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 53'
            AND oo.OperadorID = 165
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 53' ORDER BY ID DESC),
              165,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 54'
            AND oo.OperadorID = 165
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 54' ORDER BY ID DESC),
              165,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 165
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              165,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 54'
            AND oo.OperadorID = 167
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 54' ORDER BY ID DESC),
              167,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 167
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              167,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 167
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              167,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 53'
            AND oo.OperadorID = 166
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 53' ORDER BY ID DESC),
              166,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 54'
            AND oo.OperadorID = 166
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 54' ORDER BY ID DESC),
              166,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 166
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              166,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 166
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              166,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 169
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              169,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 169
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              169,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 169
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              169,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 54'
            AND oo.OperadorID = 164
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 54' ORDER BY ID DESC),
              164,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 56'
            AND oo.OperadorID = 164
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 56' ORDER BY ID DESC),
              164,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 57'
            AND oo.OperadorID = 164
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 57' ORDER BY ID DESC),
              164,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 61'
            AND oo.OperadorID = 164
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 61' ORDER BY ID DESC),
              164,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 53'
            AND oo.OperadorID = 168
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 53' ORDER BY ID DESC),
              168,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 54'
            AND oo.OperadorID = 168
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 54' ORDER BY ID DESC),
              168,
              0
          );
      END

      IF NOT EXISTS (
          SELECT 1
          FROM [dbo].[OperadorOperacao] oo
          JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
          WHERE o.[OrdemServico] = 'OS 48'
            AND oo.OperadorID = 202
      )
      BEGIN
          INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
          VALUES (
              (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 48' ORDER BY ID DESC),
              202,
              0
          );
      END

      -- =========================================
      -- NAO ENCONTRADOS NA TABELA OPERADOR (verificar cadastro / apelidos)
      -- - ALEXANDRE
      -- =========================================

      COMMIT;

      ");
    }

    public override void Down()
    {
    }
  }
}
