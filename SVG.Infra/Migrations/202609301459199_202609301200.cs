namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202609301200 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
      BEGIN TRANSACTION;

      BEGIN TRY

          ------------------------------------------------------------
          -- 1. CRIAR SEÇÃO SAAEI
          ------------------------------------------------------------

          DECLARE @SessaoSAAEIID INT;

          SELECT @SessaoSAAEIID = ID
          FROM dbo.Sessao
          WHERE Nome = 'SAAEI';


          -- Cria somente se ainda não existir
          IF @SessaoSAAEIID IS NULL
          BEGIN
              INSERT INTO dbo.Sessao
              (
                  Nome
              )
              VALUES
              (
                  'SAAEI'
              );

              SET @SessaoSAAEIID = SCOPE_IDENTITY();
          END;


          ------------------------------------------------------------
          -- 2. OPERADORES SAAEI
          ------------------------------------------------------------

          -- TILIA RUMI OKAHARA
          IF NOT EXISTS
          (
              SELECT 1
              FROM dbo.Operador
              WHERE Matricula = '63.236-8'
          )
          BEGIN
              INSERT INTO dbo.Operador
              (
                  Nome,
                  Matricula,
                  SessaoID
              )
              VALUES
              (
                  'Tilia Rumi Okahara',
                  '63.236-8',
                  @SessaoSAAEIID
              );
          END;


          -- PATRICIA ARAUJO RIBEIRO
          IF NOT EXISTS
          (
              SELECT 1
              FROM dbo.Operador
              WHERE Matricula = '78.405-2'
          )
          BEGIN
              INSERT INTO dbo.Operador
              (
                  Nome,
                  Matricula,
                  SessaoID
              )
              VALUES
              (
                  'Patricia Araujo Ribeiro',
                  '78.405-2',
                  @SessaoSAAEIID
              );
          END;


          -- REBECA SEVERO LIMONGI
          IF NOT EXISTS
          (
              SELECT 1
              FROM dbo.Operador
              WHERE Matricula = '235.251-6'
          )
          BEGIN
              INSERT INTO dbo.Operador
              (
                  Nome,
                  Matricula,
                  SessaoID
              )
              VALUES
              (
                  'Rebeca Severo Limongi',
                  '235.251-6',
                  @SessaoSAAEIID
              );
          END;


          ------------------------------------------------------------
          -- 3. MAX - SOE II
          ------------------------------------------------------------

          IF NOT EXISTS
          (
              SELECT 1
              FROM dbo.Operador
              WHERE Matricula = '1.722.557-4'
          )
          BEGIN
              INSERT INTO dbo.Operador
              (
                  Nome,
                  Alcunha,
                  Matricula,
                  NumericaDOE,
                  SessaoID
              )
              VALUES
              (
                  'Max Macedo Cavalcante',
                  'Max',
                  '1.722.557-4',
                  82,
                  2
              );
          END;


          ------------------------------------------------------------
          -- 4. CONFERÊNCIA
          ------------------------------------------------------------

          SELECT
              o.ID,
              o.Nome,
              o.Alcunha,
              o.Matricula,
              o.SessaoID,
              s.Nome AS Sessao
          FROM dbo.Operador o
          INNER JOIN dbo.Sessao s
              ON s.ID = o.SessaoID
          WHERE o.Matricula IN
          (
              '63.236-8',
              '78.405-2',
              '235.251-6',
              '1.722.557-4'
          )
          ORDER BY s.Nome, o.Nome;


          COMMIT TRANSACTION;

      END TRY
      BEGIN CATCH

          IF @@TRANCOUNT > 0
              ROLLBACK TRANSACTION;

          THROW;

      END CATCH;


      ");
    }

    public override void Down()
    {
    }
  }
}
