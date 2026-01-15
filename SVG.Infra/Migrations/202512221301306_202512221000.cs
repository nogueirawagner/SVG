namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512221000 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AddColumn<DateTime>(
        name: "DataHoraInicio",
        table: "Operacao",
        schema: "dbo",
        type: "datetime2",
        nullable: false,
        defaultValue: new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified)
      );

      migrationBuilder.AddColumn<DateTime>(
        name: "DataHoraFim",
        table: "Operacao",
        schema: "dbo",
        type: "datetime2",
        nullable: false,
        defaultValue: new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified)
      );
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
        name: "DataHoraFim",
        table: "Operacao",
        schema: "dbo"
      );

      migrationBuilder.DropColumn(
        name: "DataHoraInicio",
        table: "Operacao",
        schema: "dbo"
      );
    }
  }
}
