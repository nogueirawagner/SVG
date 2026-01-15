namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512131020 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AddColumn<string>(
          name: "OrdemServico",
          table: "Operacao",
          schema: "dbo",
          type: "varchar(500)",
          maxLength: 500,
          nullable: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
          name: "OrdemServico",
          table: "Operacao",
          schema: "dbo");
    }
  }
}
