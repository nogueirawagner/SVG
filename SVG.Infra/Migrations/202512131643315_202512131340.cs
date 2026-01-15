namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512131340 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      Sql(@"
        BEGIN TRAN;

        -- =========================================
        -- OPERACOES (OUTUBRO/2025) - geradas do Excel
        -- Horario fixo: 08:00 | SvgAberto = 0
        -- Regra: quando nao houver data na AE => D+1 da ultima data conhecida
        -- Regras de tipo:
        -- - Reforco de Seguranca Organica => TipoOperacaoID = 4 (Seguranca Organica)
        -- - Reforco de Plantao => TipoOperacaoID = 1 (Apoio)
        -- - Planejamento Operacional => TipoOperacaoID = 1 (Apoio)
        -- =========================================

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 201')
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
                '2025-10-02T08:00:00',
                'Apoio à DRACO/DECOR',
                NULL,
                2,
                1,
                '2025-10-02T08:00:00',
                0,
                'OS 201'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 202')
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
                '2025-10-03T08:00:00',
                'Reforço de segurança orgânica',
                NULL,
                7,
                4,
                '2025-10-03T08:00:00',
                0,
                'OS 202'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 203')
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
                '2025-10-03T08:00:00',
                'Alvorada',
                NULL,
                6,
                2,
                '2025-10-03T08:00:00',
                0,
                'OS 203'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 204')
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
                '2025-10-03T08:00:00',
                'Apoio à P18',
                NULL,
                3,
                1,
                '2025-10-03T08:00:00',
                0,
                'OS 204'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 205')
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
                '2025-10-04T08:00:00',
                'Apoio à SSP/DF',
                NULL,
                2,
                1,
                '2025-10-04T08:00:00',
                0,
                'OS 205'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 206')
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
                '2025-10-04T08:00:00',
                'Festa dia da criança',
                NULL,
                2,
                4,
                '2025-10-04T08:00:00',
                0,
                'OS 206'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207')
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
                '2025-10-08T08:00:00',
                'Apoio à P3',
                NULL,
                26,
                1,
                '2025-10-08T08:00:00',
                0,
                'OS 207'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 211')
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
                '2025-10-18T08:00:00',
                'Apoio à P15',
                NULL,
                3,
                1,
                '2025-10-18T08:00:00',
                0,
                'OS 211'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212')
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
                '2025-10-17T08:00:00',
                'Apoio à P14',
                NULL,
                10,
                1,
                '2025-10-17T08:00:00',
                0,
                'OS 212'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 213')
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
                '2025-10-16T08:00:00',
                'Apoio à P15',
                NULL,
                5,
                1,
                '2025-10-16T08:00:00',
                0,
                'OS 213'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 214')
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
                '2025-10-21T08:00:00',
                'Apoio ao DECOR',
                NULL,
                6,
                1,
                '2025-10-21T08:00:00',
                0,
                'OS 214'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215')
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
                '2025-10-24T08:00:00',
                'Delta',
                NULL,
                40,
                3,
                '2025-10-24T08:00:00',
                0,
                'OS 215'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 216')
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
                '2025-10-23T08:00:00',
                'Apoio à Receita Federal 23/10',
                NULL,
                0,
                1,
                '2025-10-23T08:00:00',
                0,
                'OS 216'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 217')
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
                '2025-10-23T08:00:00',
                'Apoio à CORPATRI 23/10',
                NULL,
                2,
                1,
                '2025-10-23T08:00:00',
                0,
                'OS 217'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218')
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
                '2025-10-24T08:00:00',
                'Apoio à 6ª DP 24/10',
                NULL,
                20,
                1,
                '2025-10-24T08:00:00',
                0,
                'OS 218'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 220')
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
                '2025-10-30T08:00:00',
                'Alvorada',
                NULL,
                6,
                2,
                '2025-10-30T08:00:00',
                0,
                'OS 220'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 221')
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
                '2025-10-31T08:00:00',
                'Alvorada',
                NULL,
                6,
                2,
                '2025-10-31T08:00:00',
                0,
                'OS 221'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 222')
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
                '2025-10-31T08:00:00',
                'Apoio à 20ª DP',
                NULL,
                2,
                1,
                '2025-10-31T08:00:00',
                0,
                'OS 222'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223')
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
                '2025-10-31T08:00:00',
                'Delta',
                NULL,
                20,
                3,
                '2025-10-31T08:00:00',
                0,
                'OS 223'
            );
        END

        -- =========================================
        -- OPERADOR x OPERACAO (OUTUBRO/2025)
        -- SVG = 0 para todos | SI PAKATO => OperadorID 135
        -- =========================================

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 201'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 201' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 197
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                197,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 197
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                197,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 150
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                150,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 150
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                150,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 150
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                150,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 220'
              AND oo.OperadorID = 150
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 220' ORDER BY ID DESC),
                150,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 149
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                149,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 220'
              AND oo.OperadorID = 149
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 220' ORDER BY ID DESC),
                149,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 220'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 220' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 178
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                178,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 196
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                196,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 196
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                196,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 196
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                196,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 205
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                205,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 195
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                195,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 195
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                195,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 195
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                195,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 152
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                152,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 214'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 214' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 160
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                160,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 202'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 202' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 214'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 214' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 153
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                153,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 220'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 220' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 203'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 203' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 220'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 220' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 212'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 214'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 214' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 201'
              AND oo.OperadorID = 139
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 201' ORDER BY ID DESC),
                139,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 139
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                139,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 212'
              AND oo.OperadorID = 140
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212' ORDER BY ID DESC),
                140,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 140
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                140,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 203'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 203' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 221'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 221' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 212'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 203'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 203' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 212'
              AND oo.OperadorID = 146
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212' ORDER BY ID DESC),
                146,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 212'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 212'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 202'
              AND oo.OperadorID = 173
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 202' ORDER BY ID DESC),
                173,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 173
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                173,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 176
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                176,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 177
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                177,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 179
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                179,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 203'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 203' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 221'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 221' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 220'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 220' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 202'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 202' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 217'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 217' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 221'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 221' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 183
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                183,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 203'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 203' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 221'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 221' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 202'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 202' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 203'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 203' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 221'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 221' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 221'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 221' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 190
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                190,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 190
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                190,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 190
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                190,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 217'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 217' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 222'
              AND oo.OperadorID = 144
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 222' ORDER BY ID DESC),
                144,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 202'
              AND oo.OperadorID = 194
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 202' ORDER BY ID DESC),
                194,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 194
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                194,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 214'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 214' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 202'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 202' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 214'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 214' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 212'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 214'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 214' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 204
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                204,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 204
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                204,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 205
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                205,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 222'
              AND oo.OperadorID = 205
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 222' ORDER BY ID DESC),
                205,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 223'
              AND oo.OperadorID = 205
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 223' ORDER BY ID DESC),
                205,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 211'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 211' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 213'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 213' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 204'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 204' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 206'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 206' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 213'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 213' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 204'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 204' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 212'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 213'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 213' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 205'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 205' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 213'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 213' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 204'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 204' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 206'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 206' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 213'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 213' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 207'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 207' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 211'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 211' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 212'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 218'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 218' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 205'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 205' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 211'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 211' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 212'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 212' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 202'
              AND oo.OperadorID = 202
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 202' ORDER BY ID DESC),
                202,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 215'
              AND oo.OperadorID = 133
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 215' ORDER BY ID DESC),
                133,
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

    protected override void Down(MigrationBuilder migrationBuilder)
    {
    }
  }
}
