namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512151200 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
        name: "QtdEquipe",
        table: "Operacao",
        schema: "dbo");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AddColumn<int>(
        name: "QtdEquipe",
        table: "Operacao",
        schema: "dbo",
        nullable: true);
    }
  }
}
