using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SVG.Infra.Migrations
{
  public partial class _202511191611 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      // Create table TipoOperacao
      migrationBuilder.CreateTable(
          name: "TipoOperacao",
          columns: table => new
          {
            ID = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            Nome = table.Column<string>(type: "varchar(500)", nullable: true),
            Peso = table.Column<int>(type: "int", nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_TipoOperacao", x => x.ID);
          });

      // Add column TipoOperacaoID to Operacao
      migrationBuilder.AddColumn<int>(
          name: "TipoOperacaoID",
          table: "Operacao",
          type: "int",
          nullable: false,
          defaultValue: 0);

      // Create index
      migrationBuilder.CreateIndex(
          name: "IX_Operacao_TipoOperacaoID",
          table: "Operacao",
          column: "TipoOperacaoID");

      // Add foreign key
      migrationBuilder.AddForeignKey(
          name: "FK_Operacao_TipoOperacao_TipoOperacaoID",
          table: "Operacao",
          column: "TipoOperacaoID",
          principalTable: "TipoOperacao",
          principalColumn: "ID",
          onDelete: ReferentialAction.Restrict);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Operacao_TipoOperacao_TipoOperacaoID",
          table: "Operacao");

      migrationBuilder.DropIndex(
          name: "IX_Operacao_TipoOperacaoID",
          table: "Operacao");

      migrationBuilder.DropColumn(
          name: "TipoOperacaoID",
          table: "Operacao");

      migrationBuilder.DropTable(
          name: "TipoOperacao");
    }
  }
}
