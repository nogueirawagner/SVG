namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202608241133 : DbMigration
  {
    public override void Up()
    {
      Sql(@"

        IF NOT EXISTS (
            SELECT 1
            FROM dbo.CalendarioPlantao
            WHERE SecaoID = 5
        )
        BEGIN
            INSERT INTO dbo.CalendarioPlantao
            (
                SecaoID,
                UltimoPlantao
            )
            VALUES
            (
                5,
                CONVERT(datetime, '20260817', 112)
            );
        END;

        IF NOT EXISTS (
            SELECT 1
            FROM dbo.CalendarioPlantao
            WHERE SecaoID = 6
        )
        BEGIN
            INSERT INTO dbo.CalendarioPlantao
            (
                SecaoID,
                UltimoPlantao
            )
            VALUES
            (
                6,
                CONVERT(datetime, '20260824', 112)
            );
        END;

      ");

      Sql(@"
        SET ANSI_NULLS ON
        GO

        SET QUOTED_IDENTIFIER ON
        GO

        CREATE OR ALTER FUNCTION [dbo].[fn_Escala_Sobreaviso_PorData]
        (
            @DataReferencia date
        )
        RETURNS TABLE
        AS
        RETURN
        (
            WITH SemanaReferencia AS
            (
                SELECT
                    CAST(
                        DATEADD(
                            DAY,
                            -(
                                (DATEDIFF(DAY, '19000101', @DataReferencia) % 7 + 7) % 7
                            ),
                            @DataReferencia
                        )
                        AS date
                    ) AS DataInicio
            )
            SELECT
                cp.SecaoID,
                s.Nome AS NomeSecao,
                sr.DataInicio,
                DATEADD(DAY, 6, sr.DataInicio) AS DataFim
            FROM SemanaReferencia sr
            INNER JOIN dbo.CalendarioPlantao cp
                ON cp.SecaoID IN (5, 6)
            INNER JOIN dbo.Sessao s
                ON s.ID = cp.SecaoID
            WHERE
                (
                    (
                        DATEDIFF(
                            DAY,
                            cp.UltimoPlantao,
                            sr.DataInicio
                        ) / 7
                    ) % 2 + 2
                ) % 2 = 0
        );
        GO
      ");
    }

    public override void Down()
    {
    }
  }
}
