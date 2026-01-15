namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _20251213 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"
        BEGIN TRAN;

        -- =========================================
        -- OPERACOES (NOVEMBRO/2025) - geradas do Excel
        -- Horario fixo: 08:00 | SvgAberto = 0
        -- Regra: quando nao houver data na AE => D+1 da ultima data conhecida
        -- Regras de tipo (NOVEMBRO):
        -- - Reforco de Seguranca Organica => TipoOperacaoID = 4 (Seguranca Organica)
        -- - Reforco de Plantao => TipoOperacaoID = 1 (Apoio)
        -- - Planejamento Operacional => TipoOperacaoID = 1 (Apoio)
        -- =========================================


        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 225')
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
                '2025-11-01T08:00:00',
                'Segurança Organica',
                NULL,
                5,
                1,
                '2025-11-01T08:00:00',
                0,
                'OS 225'
            );
        END


        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 227')
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
                '2025-11-03T08:00:00',
                'Reforço',
                NULL,
                5,
                1,
                '2025-11-03T08:00:00',
                0,
                'OS 227'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 229')
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
                '2025-11-04T08:00:00',
                'Apoio à CORD',
                NULL,
                5,
                1,
                '2025-11-04T08:00:00',
                0,
                'OS 229'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232')
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
                '2025-11-05T08:00:00',
                'Apoio 20ª DP',
                NULL,
                16,
                1,
                '2025-11-05T08:00:00',
                0,
                'OS 232'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234')
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
                '2025-11-06T08:00:00',
                'Apoio 18ª DP',
                NULL,
                10,
                1,
                '2025-11-06T08:00:00',
                0,
                'OS 234'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 235')
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
                '2025-11-07T08:00:00',
                'Apoio 3ª DP',
                NULL,
                4,
                1,
                '2025-11-07T08:00:00',
                0,
                'OS 235'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 237')
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
                '2025-11-12T08:00:00',
                'Apoio à P20',
                NULL,
                6,
                1,
                '2025-11-12T08:00:00',
                0,
                'OS 237'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 238')
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
                '2025-11-14T08:00:00',
                'Planejamento Operacional',
                NULL,
                2,
                1,
                '2025-11-14T08:00:00',
                0,
                'OS 238'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 239')
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
                '2025-11-13T08:00:00',
                'Alvorada',
                NULL,
                6,
                2,
                '2025-11-13T08:00:00',
                0,
                'OS 239'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 241')
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
                '2025-11-17T08:00:00',
                'Apoio ao DAG',
                NULL,
                9,
                1,
                '2025-11-17T08:00:00',
                0,
                'OS 241'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242')
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
                '2025-11-20T08:00:00',
                'DELTA',
                NULL,
                33,
                3,
                '2025-11-20T08:00:00',
                0,
                'OS 242'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 243')
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
                '2025-11-18T08:00:00',
                'Alvorada',
                NULL,
                6,
                2,
                '2025-11-18T08:00:00',
                0,
                'OS 243'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245')
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
                '2025-11-24T08:00:00',
                'Apoio à P18',
                NULL,
                15,
                1,
                '2025-11-24T08:00:00',
                0,
                'OS 245'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 246')
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
                '2025-11-26T08:00:00',
                'Apoio à P33',
                NULL,
                7,
                1,
                '2025-11-26T08:00:00',
                0,
                'OS 246'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247')
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
                '2025-11-27T08:00:00',
                'Planejamento Operacional',
                NULL,
                37,
                1,
                '2025-11-27T08:00:00',
                0,
                'OS 247'
            );
        END

        -- =========================================
        -- OPERADOR x OPERACAO (NOVEMBRO/2025)
        -- SVG = 0 para todos | SI PAKATO => OperadorID 135
        -- =========================================

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 235'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 235' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 235'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 235' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 234'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 237'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 237' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 241'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 241' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 234'
              AND oo.OperadorID = 152
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234' ORDER BY ID DESC),
                152,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 237'
              AND oo.OperadorID = 152
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 237' ORDER BY ID DESC),
                152,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 241'
              AND oo.OperadorID = 152
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 241' ORDER BY ID DESC),
                152,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 152
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                152,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 237'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 237' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 241'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 241' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 241'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 241' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 229'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 229' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 234'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 237'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 237' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 241'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 241' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 241'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 241' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 243'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 243' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 225'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 225' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 227'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 227' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 234'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 241'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 241' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 234'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 237'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 237' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 241'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 241' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 234'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 237'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 237' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 241'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 241' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 243'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 243' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 239'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 239' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 239'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 239' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 243'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 243' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 246'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 246' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 149
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                149,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 149
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                149,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 150
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                150,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 171
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                171,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 171
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                171,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 225'
              AND oo.OperadorID = 173
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 225' ORDER BY ID DESC),
                173,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 173
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                173,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 173
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                173,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 176
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                176,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 176
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                176,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 174
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                174,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 174
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                174,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 177
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                177,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 177
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                177,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 225'
              AND oo.OperadorID = 179
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 225' ORDER BY ID DESC),
                179,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 179
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                179,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 243'
              AND oo.OperadorID = 179
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 243' ORDER BY ID DESC),
                179,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 179
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                179,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 225'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 225' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 225'
              AND oo.OperadorID = 178
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 225' ORDER BY ID DESC),
                178,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 178
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                178,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 227'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 227' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 229'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 229' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 229'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 229' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 183
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                183,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 183
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                183,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 227'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 227' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 229'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 229' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 225'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 225' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 229'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 229' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 239'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 239' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 239'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 239' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 239'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 239' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 225'
              AND oo.OperadorID = 194
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 225' ORDER BY ID DESC),
                194,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 243'
              AND oo.OperadorID = 195
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 243' ORDER BY ID DESC),
                195,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 245'
              AND oo.OperadorID = 195
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 245' ORDER BY ID DESC),
                195,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 196
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                196,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 196
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                196,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 239'
              AND oo.OperadorID = 197
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 239' ORDER BY ID DESC),
                197,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 197
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                197,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 225'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 225' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 234'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 243'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 243' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 246'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 246' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 225'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 225' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 227'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 227' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 234'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 246'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 246' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 232'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 232' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 234'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 246'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 246' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 204
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                204,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 234'
              AND oo.OperadorID = 205
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 234' ORDER BY ID DESC),
                205,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 205
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                205,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 205
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                205,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 200
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                200,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 246'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 246' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 246'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 246' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 235'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 235' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 246'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 246' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 238'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 238' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 247'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 247' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 235'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 235' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 238'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 238' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 242'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 242' ORDER BY ID DESC),
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
