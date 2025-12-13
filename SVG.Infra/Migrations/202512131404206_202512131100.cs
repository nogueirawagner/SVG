namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512131100 : DbMigration
  {
    public override void Up()
    {
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
