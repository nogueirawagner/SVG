namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512091848 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AddColumn<string>(
          name: "Alcunha",
          table: "Operador",
          schema: "dbo",
          type: "varchar(500)",
          maxLength: 500,
          nullable: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
          name: "Alcunha",
          table: "Operador",
          schema: "dbo");
    }
  }
}
