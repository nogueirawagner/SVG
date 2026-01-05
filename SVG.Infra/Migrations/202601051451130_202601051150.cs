namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601051150 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        IF NOT EXISTS (
            SELECT 1 
            FROM sys.fulltext_catalogs 
            WHERE name = 'FTC_DOE'
        )
        BEGIN
            CREATE FULLTEXT CATALOG FTC_DOE AS DEFAULT;
        END
      ");
    }

    public override void Down()
    {
    }
  }
}
