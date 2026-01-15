using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SVG.Infra.Migrations
{
  public partial class Initial : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Operador",
          columns: table => new
          {
            ID = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            Matricula = table.Column<string>(type: "varchar(500)", nullable: true),
            Nome = table.Column<string>(type: "varchar(500)", nullable: true),
            Sessao = table.Column<string>(type: "varchar(500)", nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Operador", x => x.ID);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Operador");
    }
  }
}
