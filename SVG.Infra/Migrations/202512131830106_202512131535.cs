namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512131535 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        BEGIN TRAN;

        -- =========================================
        -- OPERACOES (JANEIRO/2025) - geradas do Excel (ATUALIZADO)
        -- Horario fixo: 08:00 | SvgAberto = 0
        -- Regra: quando nao houver data na AE => D+1 da ultima data conhecida
        -- Regras de tipo:
        -- - Reforco de Seguranca Organica => TipoOperacaoID = 4 (Seguranca Organica)
        -- - Reforco de Plantao => TipoOperacaoID = 1 (Apoio)
        -- - Planejamento Operacional => TipoOperacaoID = 1 (Apoio)
        -- =========================================

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 001')
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
                '2025-01-03T08:00:00',
                'Segurança Orgânica',
                NULL,
                8,
                4,
                '2025-01-03T08:00:00',
                0,
                'OS 001'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002')
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
                '2025-01-04T08:00:00',
                'Reforço de Plantão',
                NULL,
                16,
                1,
                '2025-01-04T08:00:00',
                0,
                'OS 002'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 003')
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
                '2025-01-07T08:00:00',
                'Operação Alvorada',
                NULL,
                4,
                2,
                '2025-01-07T08:00:00',
                0,
                'OS 003'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 004')
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
                '2025-01-08T08:00:00',
                'Operação Alvorada',
                NULL,
                4,
                2,
                '2025-01-08T08:00:00',
                0,
                'OS 004'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005')
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
                '2025-01-09T08:00:00',
                'Apoio P23',
                NULL,
                32,
                1,
                '2025-01-09T08:00:00',
                0,
                'OS 005'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 007')
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
                '2025-01-07T08:00:00',
                'Apoio P15',
                NULL,
                5,
                1,
                '2025-01-07T08:00:00',
                0,
                'OS 007'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 008')
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
                '2025-01-10T08:00:00',
                'Apoio DEMA',
                NULL,
                4,
                1,
                '2025-01-10T08:00:00',
                0,
                'OS 008'
            );
        END


        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010')
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
                '2025-01-10T08:00:00',
                'Apoio DEMA',
                NULL,
                4,
                4,
                '2025-01-10T08:00:00',
                0,
                'OS 010'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 011')
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
                '2025-01-14T08:00:00',
                'Operação Alvorada',
                NULL,
                4,
                2,
                '2025-01-14T08:00:00',
                0,
                'OS 011'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012')
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
                '2025-01-15T08:00:00',
                'Apoio P05',
                NULL,
                17,
                1,
                '2025-01-15T08:00:00',
                0,
                'OS 012'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013')
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
                '2025-01-16T08:00:00',
                'Apoio P16',
                NULL,
                12,
                1,
                '2025-01-16T08:00:00',
                0,
                'OS 013'
            );
        END


        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014')
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
                '2025-01-19T08:00:00',
                'Apoio DEMA',
                NULL,
                4,
                4,
                '2025-01-19T08:00:00',
                0,
                'OS 014'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 016')
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
                '2025-01-27T08:00:00',
                'Operação Alvorada',
                NULL,
                4,
                2,
                '2025-01-27T08:00:00',
                0,
                'OS 016'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017')
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
                '2025-01-29T08:00:00',
                'Apoio P26',
                NULL,
                34,
                1,
                '2025-01-29T08:00:00',
                0,
                'OS 017'
            );
        END

        -- =========================================
        -- OPERADOR x OPERACAO (JANEIRO/2025)
        -- SVG = 0 para todos | SI PAKATO => OperadorID 135
        -- =========================================

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 200
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                200,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 200
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                200,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 200
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                200,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 152
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                152,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 152
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                152,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 152
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                152,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 153
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                153,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 153
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                153,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 153
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                153,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 011'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 011' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 011'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 011' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 016'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 016' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 003'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 003' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 016'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 016' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 139
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                139,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 140
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                140,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 140
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                140,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 140
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                140,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 001'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 001' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 003'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 003' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 008'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 008' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 001'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 001' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 004'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 004' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 008'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 008' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 145
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                145,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 003'
              AND oo.OperadorID = 146
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 003' ORDER BY ID DESC),
                146,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 008'
              AND oo.OperadorID = 146
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 008' ORDER BY ID DESC),
                146,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 146
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                146,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 008'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 008' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 001'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 001' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 001'
              AND oo.OperadorID = 173
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 001' ORDER BY ID DESC),
                173,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 174
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                174,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 004'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 004' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 001'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 001' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 004'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 004' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 016'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 016' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 185
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                185,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 016'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 016' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 003'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 003' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 001'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 001' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 004'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 004' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 001'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 001' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 014'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 014' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 013'
              AND oo.OperadorID = 192
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 013' ORDER BY ID DESC),
                192,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 011'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 011' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 002'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 002' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 010'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 010' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 011'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 011' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 007'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 007' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 007'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 007' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 007'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 007' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 007'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 007' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 005'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 005' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 007'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 007' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 012'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 012' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 017'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 017' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 001'
              AND oo.OperadorID = 202
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 001' ORDER BY ID DESC),
                202,
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
