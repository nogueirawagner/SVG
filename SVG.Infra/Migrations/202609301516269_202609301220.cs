namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202609301220 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
      BEGIN TRANSACTION;

      BEGIN TRY

          ------------------------------------------------------------
          -- RUY LINS WANDERLEY NETO
          -- Numérica DOE: 83
          -- SeçãoID: 6
          ------------------------------------------------------------

          IF NOT EXISTS
          (
              SELECT 1
              FROM dbo.Operador
              WHERE Matricula = '231.110-0'
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
                  'Ruy Lins Wanderley Neto',
                  'Ruy',
                  '231.110-0',
                  83,
                  6
              );
          END;


          ------------------------------------------------------------
          -- CONFERÊNCIA
          ------------------------------------------------------------

          SELECT
              o.ID,
              o.Nome,
              o.Alcunha,
              o.Matricula,
              o.NumericaDOE,
              o.SessaoID,
              s.Nome AS Sessao
          FROM dbo.Operador o
          INNER JOIN dbo.Sessao s
              ON s.ID = o.SessaoID
          WHERE o.Matricula = '231.110-0';


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
