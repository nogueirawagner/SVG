namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512291720 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "CandidatoSVGOperacao",
          schema: "dbo",
          columns: table => new
          {
            ID = table.Column<int>(type: "int", nullable: false)
              .Annotation("SqlServer:Identity", "1,1"),
            OperadorID = table.Column<int>(type: "int", nullable: false),
            OperacaoID = table.Column<int>(type: "int", nullable: false),
            DataHoraCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_CandidatoSVGOperacao", x => x.ID);
          });

    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "CandidatoSVGOperacao",
          schema: "dbo");
    }
  }
}
