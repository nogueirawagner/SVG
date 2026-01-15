namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202511271810 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AddColumn<DateTime>(
          name: "DataHoraCriacao",
          table: "Operacao",
          type: "datetime2",
          nullable: false,
          defaultValueSql: "GETDATE()"
      );
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
          name: "DataHoraCriacao",
          table: "Operacao"
      );
    }
  }
}
