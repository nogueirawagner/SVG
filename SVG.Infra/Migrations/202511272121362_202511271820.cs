namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202511271820 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"UPDATE Operacao SET DataHoraCriacao = GETDATE()");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
    }
  }
}
