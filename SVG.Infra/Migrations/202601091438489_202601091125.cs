namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202601091125 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "CalendarioPlantao",
          columns: table => new
          {
            ID = table.Column<int>(nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),

            SecaoID = table.Column<int>(nullable: false),

            UltimoPlantao = table.Column<DateTime>(nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_CalendarioPlantao", x => x.ID);

            table.ForeignKey(
              name: "FK_CalendarioPlantao_Sessao_SecaoID",
              column: x => x.SecaoID,
              principalTable: "Sessao",
              principalColumn: "ID",
              onDelete: ReferentialAction.Cascade);
          });

      migrationBuilder.CreateIndex(
          name: "IX_CalendarioPlantao_SecaoID",
          table: "CalendarioPlantao",
          column: "SecaoID");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "CalendarioPlantao");
    }
  }
}
