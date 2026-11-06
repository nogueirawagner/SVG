namespace SVG.Infra.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class _202611061808 : DbMigration
    {
        public override void Up()
        {
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'LinkGoogleMaps') IS NULL
    ALTER TABLE dbo.Planejamento ADD LinkGoogleMaps varchar(2048) NULL;");
        }

        public override void Down()
        {
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'LinkGoogleMaps') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN LinkGoogleMaps;");
        }
    }
}
