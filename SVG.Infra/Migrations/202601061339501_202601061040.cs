namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601061040 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        IF NOT EXISTS (
            SELECT 1 
            FROM Sessao 
            WHERE Nome = 'SORG'
        )
        BEGIN
            INSERT INTO Sessao (Nome)
            VALUES ('SORG');
        END
      ");
    }

    public override void Down()
    {
    }
  }
}
