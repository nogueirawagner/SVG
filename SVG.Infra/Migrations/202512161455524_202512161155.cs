namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512161155 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"update OperadorOperacao set SVG = 1");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
    }
  }
}
