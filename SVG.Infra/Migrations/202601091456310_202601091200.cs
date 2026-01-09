namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601091200 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
      CREATE OR ALTER FUNCTION dbo.fn_Escala_Plantao_PorData
      (
          @DataReferencia date
      )
      RETURNS TABLE
      AS
      RETURN
      (
          WITH Dias AS
          (
              SELECT 
                  @DataReferencia AS DataPlantao,
                  0 AS OffsetDia
              UNION ALL 
              SELECT 
                  DATEADD(day, 1, @DataReferencia),
                  1
              UNION ALL 
              SELECT 
                  DATEADD(day, 2, @DataReferencia),
                  2
          )
          SELECT
              cp.SecaoID,
              d.DataPlantao,
              CASE d.OffsetDia
                WHEN 0 THEN 0
                WHEN 1 THEN 1
                WHEN 2 THEN 2
            END AS Situacao
          FROM Dias d
          JOIN dbo.CalendarioPlantao cp
            ON ((DATEDIFF(day, cp.UltimoPlantao, d.DataPlantao) % 4) + 4) % 4 = 0
      );");
    }

    public override void Down()
    {
    }
  }
}
