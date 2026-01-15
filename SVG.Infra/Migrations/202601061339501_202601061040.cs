namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202601061040 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"
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

    protected override void Down(MigrationBuilder migrationBuilder)
    {
    }
  }
}
