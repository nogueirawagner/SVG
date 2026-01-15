namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512112202 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AddColumn<bool>(
          name: "SvgAberto",
          table: "Operacao",
          schema: "dbo",
          type: "bit",
          nullable: false);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
          name: "SvgAberto",
          table: "Operacao",
          schema: "dbo");
    }
  }
}
