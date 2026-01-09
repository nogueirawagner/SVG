namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601091140 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        INSERT INTO CalendarioPlantao (SecaoID, UltimoPlantao)
          VALUES
              (1, '2026-01-03T00:00:00'), -- SOE I  (sábado)
              (2, '2026-01-04T00:00:00'), -- SOE II (domingo)
              (3, '2026-01-05T00:00:00'), -- SOE III (segunda)
              (4, '2026-01-06T00:00:00'); -- SOE IV (terça)
          ");
    }

    public override void Down()
    {
    }
  }
}
