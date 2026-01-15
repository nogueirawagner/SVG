namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512221135 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AlterColumn<DateTime?>(
          name: "DataHoraInicio",
          table: "Operacao",
          schema: "dbo",
          type: "datetime2",
          nullable: true,
          oldClrType: typeof(DateTime),
          oldType: "datetime2",
          oldNullable: false);

      migrationBuilder.AlterColumn<DateTime?>(
          name: "DataHoraFim",
          table: "Operacao",
          schema: "dbo",
          type: "datetime2",
          nullable: true,
          oldClrType: typeof(DateTime),
          oldType: "datetime2",
          oldNullable: false);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AlterColumn<DateTime>(
          name: "DataHoraFim",
          table: "Operacao",
          schema: "dbo",
          type: "datetime2",
          nullable: false,
          oldClrType: typeof(DateTime),
          oldType: "datetime2",
          oldNullable: true);

      migrationBuilder.AlterColumn<DateTime>(
          name: "DataHoraInicio",
          table: "Operacao",
          schema: "dbo",
          type: "datetime2",
          nullable: false,
          oldClrType: typeof(DateTime),
          oldType: "datetime2",
          oldNullable: true);
    }
  }
}
