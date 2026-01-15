namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202601051150 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"
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

    protected override void Down(MigrationBuilder migrationBuilder)
    {
    }
  }
}
