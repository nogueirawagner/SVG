namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512131445 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"
        BEGIN TRAN;

        -- =========================================
        -- OPERACOES (SETEMBRO/2025) - geradas do Excel
        -- Horario fixo: 08:00 | SvgAberto = 0
        -- Regra: quando nao houver data na AE => D+1 da ultima data conhecida
        -- Regras de tipo:
        -- - Reforco de Seguranca Organica => TipoOperacaoID = 4 (Seguranca Organica)
        -- - Reforco de Plantao => TipoOperacaoID = 1 (Apoio)
        -- - Planejamento Operacional => TipoOperacaoID = 1 (Apoio)
        -- =========================================

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176')
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
                '2025-09-02T08:00:00',
                'Apoio à P20',
                NULL,
                22,
                1,
                '2025-09-02T08:00:00',
                0,
                'OS 176'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 177')
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
                '2025-09-03T08:00:00',
                'Reforço de segurança orgânica',
                NULL,
                2,
                4,
                '2025-09-03T08:00:00',
                0,
                'OS 177'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178')
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
                '2025-09-05T08:00:00',
                'Apoio à P18',
                NULL,
                18,
                1,
                '2025-09-05T08:00:00',
                0,
                'OS 178'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 179')
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
                '2025-09-05T08:00:00',
                'Exposição da Patria',
                NULL,
                18,
                4,
                '2025-09-05T08:00:00',
                0,
                'OS 179'
            );
        END


        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 181')
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
                '2025-09-09T08:00:00',
                'Alvorada',
                NULL,
                6,
                2,
                '2025-09-09T08:00:00',
                0,
                'OS 181'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 183')
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
                '2025-09-10T08:00:00',
                'Apoio à CORPATRI',
                NULL,
                4,
                1,
                '2025-09-10T08:00:00',
                0,
                'OS 183'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184')
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
                '2025-09-11T08:00:00',
                'Apoio à P8',
                NULL,
                33,
                1,
                '2025-09-11T08:00:00',
                0,
                'OS 184'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 185')
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
                '2025-09-12T08:00:00',
                'Apoio à P1',
                NULL,
                7,
                1,
                '2025-09-12T08:00:00',
                0,
                'OS 185'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 187')
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
                '2025-09-18T08:00:00',
                'Apoio à P33',
                NULL,
                6,
                1,
                '2025-09-18T08:00:00',
                0,
                'OS 187'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 188')
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
                '2025-09-19T08:00:00',
                'Apoio à P33',
                NULL,
                3,
                1,
                '2025-09-19T08:00:00',
                0,
                'OS 188'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189')
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
                '2025-09-17T08:00:00',
                'Apoio à SGC',
                NULL,
                13,
                1,
                '2025-09-17T08:00:00',
                0,
                'OS 189'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192')
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
                '2025-09-18T08:00:00',
                'Apoio à P6',
                NULL,
                22,
                1,
                '2025-09-18T08:00:00',
                0,
                'OS 192'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 193')
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
                '2025-09-20T08:00:00',
                'Apoio à P15',
                NULL,
                3,
                1,
                '2025-09-20T08:00:00',
                0,
                'OS 193'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191')
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
                '2025-09-19T08:00:00',
                'Apoio à p 31',
                NULL,
                17,
                1,
                '2025-09-19T08:00:00',
                0,
                'OS 191'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 194')
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
                '2025-09-20T08:00:00',
                'Apoio à DPCev e DIPO',
                NULL,
                8,
                1,
                '2025-09-20T08:00:00',
                0,
                'OS 194'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198')
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
                '2025-09-26T08:00:00',
                'Apoio à 19 DP',
                NULL,
                15,
                1,
                '2025-09-26T08:00:00',
                0,
                'OS 198'
            );
        END

        IF NOT EXISTS (SELECT 1 FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 200')
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
                '2025-09-26T08:00:00',
                'Apoio à CEPEMA',
                NULL,
                1,
                1,
                '2025-09-26T08:00:00',
                0,
                'OS 200'
            );
        END

        -- =========================================
        -- OPERADOR x OPERACAO (SETEMBRO/2025)
        -- SVG = 0 para todos | SI PAKATO => OperadorID 135
        -- =========================================

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 130
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                130,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 194'
              AND oo.OperadorID = 131
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 194' ORDER BY ID DESC),
                131,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 197
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                197,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 197
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                197,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 197
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                197,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 150
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                150,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 150
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                150,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 150
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                150,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 150
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                150,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 150
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                150,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 149
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                149,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 149
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                149,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 149
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                149,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 200'
              AND oo.OperadorID = 149
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 200' ORDER BY ID DESC),
                149,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 161
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                161,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 188
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                188,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 178
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                178,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 178
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                178,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 178
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                178,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 196
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                196,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 196
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                196,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 196
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                196,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 180
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                180,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 205
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                205,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 200
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                200,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 151
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                151,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 152
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                152,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 152
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                152,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 155
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                155,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 159
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                159,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 187
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                187,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 153
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                153,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 153
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                153,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 154
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                154,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 181'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 181' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 132
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                132,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 133
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                133,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 135
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                135,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 136
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                136,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 139
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                139,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 139
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                139,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 139
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                139,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 140
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                140,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 140
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                140,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 194'
              AND oo.OperadorID = 140
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 194' ORDER BY ID DESC),
                140,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 183'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 183' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 194'
              AND oo.OperadorID = 141
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 194' ORDER BY ID DESC),
                141,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 194'
              AND oo.OperadorID = 142
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 194' ORDER BY ID DESC),
                142,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 143
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                143,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 145
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                145,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 145
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                145,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 145
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                145,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 194'
              AND oo.OperadorID = 145
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 194' ORDER BY ID DESC),
                145,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 194'
              AND oo.OperadorID = 146
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 194' ORDER BY ID DESC),
                146,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 194'
              AND oo.OperadorID = 147
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 194' ORDER BY ID DESC),
                147,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 177'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 177' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 194'
              AND oo.OperadorID = 148
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 194' ORDER BY ID DESC),
                148,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 177
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                177,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 177
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                177,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 181
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                181,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 182
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                182,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 181'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 181' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 184
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                184,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 183
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                183,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 181'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 181' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 186
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                186,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 181'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 181' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 158
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                158,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 181'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 181' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 157
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                157,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 177'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 177' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 189'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 189' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 189
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                189,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 181'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 181' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 183'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 183' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 191
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                191,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 183'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 183' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 193
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                193,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 183'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 183' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 156
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                156,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 144
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                144,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 194
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                194,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 198
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                198,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 199
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                199,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 192'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 192' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 198'
              AND oo.OperadorID = 206
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 198' ORDER BY ID DESC),
                206,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 176'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 176' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 191'
              AND oo.OperadorID = 201
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 191' ORDER BY ID DESC),
                201,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 185'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 185' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 187'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 187' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 188'
              AND oo.OperadorID = 162
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 188' ORDER BY ID DESC),
                162,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 179'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 179' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 185'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 185' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 187'
              AND oo.OperadorID = 165
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 187' ORDER BY ID DESC),
                165,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 185'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 185' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 187'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 187' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 188'
              AND oo.OperadorID = 167
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 188' ORDER BY ID DESC),
                167,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 178'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 178' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 179'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 179' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 185'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 185' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 188'
              AND oo.OperadorID = 166
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 188' ORDER BY ID DESC),
                166,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 185'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 185' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 187'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 187' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 193'
              AND oo.OperadorID = 169
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 193' ORDER BY ID DESC),
                169,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 185'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 185' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 187'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 187' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 193'
              AND oo.OperadorID = 164
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 193' ORDER BY ID DESC),
                164,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 184'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 184' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 185'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 185' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 187'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 187' ORDER BY ID DESC),
                168,
                0
            );
        END

        IF NOT EXISTS (
            SELECT 1
            FROM [dbo].[OperadorOperacao] oo
            JOIN [dbo].[Operacao] o ON o.ID = oo.OperacaoID
            WHERE o.[OrdemServico] = 'OS 193'
              AND oo.OperadorID = 168
        )
        BEGIN
            INSERT INTO [dbo].[OperadorOperacao] ([OperacaoID], [OperadorID], [SVG])
            VALUES (
                (SELECT TOP 1 ID FROM [dbo].[Operacao] WHERE [OrdemServico] = 'OS 193' ORDER BY ID DESC),
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
