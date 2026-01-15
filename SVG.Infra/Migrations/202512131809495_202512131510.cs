namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512131510 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"
        BEGIN TRAN;

        -- =========================================
        -- OPERACOES (MAIO/2025) - geradas do Excel
        -- Horario fixo: 08:00 | SvgAberto = 0
        -- Regra: quando nao houver data na AE => D+1 da ultima data conhecida
        -- Regras de tipo:
        -- - Reforco de Seguranca Organica => TipoOperacaoID = 4 (Seguranca Organica)
        -- - Reforco de Plantao => TipoOperacaoID = 1 (Apoio)
        -- - Planejamento Operacional => TipoOperacaoID = 1 (Apoio)
        -- =========================================
        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 88')
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
                '2025-05-06T08:00:00',
                'Apoio à P33',
                NULL,
                4,
                4,
                '2025-05-06T08:00:00',
                0,
                'OS 88'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 89')
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
                '2025-05-06T08:00:00',
                'Reforço',
                NULL,
                4,
                4,
                '2025-05-06T08:00:00',
                0,
                'OS 89'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 90')
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
                '2025-05-06T08:00:00',
                'Apoio à P33',
                NULL,
                4,
                1,
                '2025-05-06T08:00:00',
                0,
                'OS 90'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 91')
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
                '2025-05-10T08:00:00',
                'Apoio à SSP/DF',
                NULL,
                2,
                1,
                '2025-05-10T08:00:00',
                0,
                'OS 91'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 92')
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
                '2025-05-08T08:00:00',
                'Apoio à P3',
                NULL,
                5,
                1,
                '2025-05-08T08:00:00',
                0,
                'OS 92'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94')
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
                '2025-05-09T08:00:00',
                'Apoio à P15',
                NULL,
                10,
                1,
                '2025-05-09T08:00:00',
                0,
                'OS 94'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95')
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
                '2025-05-13T08:00:00',
                'Apoio à P14',
                NULL,
                18,
                1,
                '2025-05-13T08:00:00',
                0,
                'OS 95'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 96')
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
                '2025-05-13T08:00:00',
                'Apoio à P23',
                NULL,
                8,
                1,
                '2025-05-13T08:00:00',
                0,
                'OS 96'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97')
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
                '2025-05-14T08:00:00',
                'Apoio à CORD',
                NULL,
                41,
                1,
                '2025-05-14T08:00:00',
                0,
                'OS 97'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98')
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
                '2025-05-15T08:00:00',
                'Apoio à  P26',
                NULL,
                14,
                1,
                '2025-05-15T08:00:00',
                0,
                'OS 98'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100')
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
                '2025-05-20T08:00:00',
                'Apoio à P23',
                NULL,
                13,
                1,
                '2025-05-20T08:00:00',
                0,
                'OS 100'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 101')
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
                '2025-05-22T08:00:00',
                'Alvorada',
                NULL,
                4,
                2,
                '2025-05-22T08:00:00',
                0,
                'OS 101'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 102')
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
                '2025-05-23T08:00:00',
                'Alvorada',
                NULL,
                4,
                2,
                '2025-05-23T08:00:00',
                0,
                'OS 102'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 103')
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
                '2025-05-22T08:00:00',
                'Apoio à P30',
                NULL,
                2,
                1,
                '2025-05-22T08:00:00',
                0,
                'OS 103'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107')
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
                '2025-05-31T08:00:00',
                'DELTA',
                NULL,
                24,
                3,
                '2025-05-31T08:00:00',
                0,
                'OS 107'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 108')
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
                '2025-05-30T08:00:00',
                'Alvorada',
                NULL,
                4,
                2,
                '2025-05-30T08:00:00',
                0,
                'OS 108'
            );
        END

        -- =========================================
        -- OPERADOR x OPERACAO (MAIO/2025)
        -- SVG = 0 para todos | SI PAKATO => OperadorID 135
        -- =========================================

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 200
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                200,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 200
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                200,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 90'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 90' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 94'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 101'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 101' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 92'
              AND oo.OperadorID = 153
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 92' ORDER BY ID DESC),
                153,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 153
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                153,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 153
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                153,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 90'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 90' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 94'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 101'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 101' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 102'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 102' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 88'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 88' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 101'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 101' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 108'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 108' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 94'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 96'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 96' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 96'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 96' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 137
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                137,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 139
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                139,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 139
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                139,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 145
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                145,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 145
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                145,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 146
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                146,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 146
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                146,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 146
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                146,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 170
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                170,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 171
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                171,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 90'
              AND oo.OperadorID = 173
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 90' ORDER BY ID DESC),
                173,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 102'
              AND oo.OperadorID = 173
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 102' ORDER BY ID DESC),
                173,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 173
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                173,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 177
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                177,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 89'
              AND oo.OperadorID = 179
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 89' ORDER BY ID DESC),
                179,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 179
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                179,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 89'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 89' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 89'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 89' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 92'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 92' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 102'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 102' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 88'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 88' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 88'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 88' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 89'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 89' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 92'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 92' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 102'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 102' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 92'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 92' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 94'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 190
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                190,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 190
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                190,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 89'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 89' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 92'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 92' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 94'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 89'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 89' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 95'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 95' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 88'
              AND oo.OperadorID = 192
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 88' ORDER BY ID DESC),
                192,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 192
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                192,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 94'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 144
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                144,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 194
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                194,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 194
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                194,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 89'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 89' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 90'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 90' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 96'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 96' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 101'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 101' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 108'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 108' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 96'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 96' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 108'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 108' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 96'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 96' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 108'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 108' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 94'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 96'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 96' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 204
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                204,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 107'
              AND oo.OperadorID = 204
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 107' ORDER BY ID DESC),
                204,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 96'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 96' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 103'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 103' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 94'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 94'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 96'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 96' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 91'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 91' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 91'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 91' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 100'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 100' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 94'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 94' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 97'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 97' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 98'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 98' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 103'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 103' ORDER BY ID DESC),
                168,
                0
            );
        END

        COMMIT;

      ");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
    }
  }
}
