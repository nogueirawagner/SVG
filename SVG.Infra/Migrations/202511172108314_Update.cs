using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SVG.Infra.Migrations
{
  public partial class Update : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Equipe",
          columns: table => new
          {
            ID = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            Nome = table.Column<string>(type: "varchar(500)", nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Equipe", x => x.ID);
          });

      migrationBuilder.CreateTable(
          name: "Operacao",
          columns: table => new
          {
            ID = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            DataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
            Objeto = table.Column<string>(type: "varchar(500)", nullable: true),
            DP = table.Column<string>(type: "varchar(500)", nullable: true),
            Coordenador = table.Column<string>(type: "varchar(500)", nullable: true),
            QtdEquipe = table.Column<int>(type: "int", nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Operacao", x => x.ID);
          });

      migrationBuilder.CreateTable(
          name: "Viatura",
          columns: table => new
          {
            ID = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            Modelo = table.Column<string>(type: "varchar(500)", nullable: true),
            Prefixo = table.Column<string>(type: "varchar(500)", nullable: true),
            Placa = table.Column<string>(type: "varchar(500)", nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Viatura", x => x.ID);
          });

      migrationBuilder.CreateTable(
          name: "OperadorOperacao",
          columns: table => new
          {
            ID = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            OperacaoID = table.Column<int>(type: "int", nullable: false),
            OperadorID = table.Column<int>(type: "int", nullable: false),
            SVG = table.Column<bool>(type: "bit", nullable: false),
            Equipe = table.Column<int>(type: "int", nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_OperadorOperacao", x => x.ID);
            table.ForeignKey(
                      name: "FK_OperadorOperacao_Operacao_OperacaoID",
                      column: x => x.OperacaoID,
                      principalTable: "Operacao",
                      principalColumn: "ID",
                      onDelete: ReferentialAction.Restrict);
            table.ForeignKey(
                      name: "FK_OperadorOperacao_Operador_OperadorID",
                      column: x => x.OperadorID,
                      principalTable: "Operador",
                      principalColumn: "ID",
                      onDelete: ReferentialAction.Restrict);
          });

      migrationBuilder.CreateTable(
          name: "ViaturaOperacao",
          columns: table => new
          {
            ID = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            ViaturaID = table.Column<int>(type: "int", nullable: false),
            OperacaoID = table.Column<int>(type: "int", nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_ViaturaOperacao", x => x.ID);
            table.ForeignKey(
                      name: "FK_ViaturaOperacao_Operacao_OperacaoID",
                      column: x => x.OperacaoID,
                      principalTable: "Operacao",
                      principalColumn: "ID",
                      onDelete: ReferentialAction.Restrict);
            table.ForeignKey(
                      name: "FK_ViaturaOperacao_Viatura_ViaturaID",
                      column: x => x.ViaturaID,
                      principalTable: "Viatura",
                      principalColumn: "ID",
                      onDelete: ReferentialAction.Restrict);
          });

      migrationBuilder.CreateIndex(
          name: "IX_OperadorOperacao_OperacaoID",
          table: "OperadorOperacao",
          column: "OperacaoID");

      migrationBuilder.CreateIndex(
          name: "IX_OperadorOperacao_OperadorID",
          table: "OperadorOperacao",
          column: "OperadorID");

      migrationBuilder.CreateIndex(
          name: "IX_ViaturaOperacao_ViaturaID",
          table: "ViaturaOperacao",
          column: "ViaturaID");

      migrationBuilder.CreateIndex(
          name: "IX_ViaturaOperacao_OperacaoID",
          table: "ViaturaOperacao",
          column: "OperacaoID");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(name: "ViaturaOperacao");
      migrationBuilder.DropTable(name: "OperadorOperacao");
      migrationBuilder.DropTable(name: "Viatura");
      migrationBuilder.DropTable(name: "Operacao");
      migrationBuilder.DropTable(name: "Equipe");
    }
  }
}
