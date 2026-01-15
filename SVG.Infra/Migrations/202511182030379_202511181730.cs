using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SVG.Infra.Migrations
{
  public partial class _202511181730 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      // Add SessaoID columns
      migrationBuilder.AddColumn<int>(
          name: "SessaoID",
          table: "Operador",
          type: "int",
          nullable: false,
          defaultValue: 0);

      migrationBuilder.AddColumn<int>(
          name: "SessaoID",
          table: "Viatura",
          type: "int",
          nullable: false,
          defaultValue: 0);

      // Create indexes
      migrationBuilder.CreateIndex(
          name: "IX_Operador_SessaoID",
          table: "Operador",
          column: "SessaoID");

      migrationBuilder.CreateIndex(
          name: "IX_Viatura_SessaoID",
          table: "Viatura",
          column: "SessaoID");

      // Add foreign keys
      migrationBuilder.AddForeignKey(
          name: "FK_Operador_Sessao_SessaoID",
          table: "Operador",
          column: "SessaoID",
          principalTable: "Sessao",
          principalColumn: "ID",
          onDelete: ReferentialAction.Restrict);

      migrationBuilder.AddForeignKey(
          name: "FK_Viatura_Sessao_SessaoID",
          table: "Viatura",
          column: "SessaoID",
          principalTable: "Sessao",
          principalColumn: "ID",
          onDelete: ReferentialAction.Restrict);

      // Drop old columns
      migrationBuilder.DropColumn(
          name: "Sessao",
          table: "Operador");

      migrationBuilder.DropColumn(
          name: "Equipe",
          table: "Viatura");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      // Recreate old columns
      migrationBuilder.AddColumn<string>(
          name: "Equipe",
          table: "Viatura",
          type: "varchar(500)",
          nullable: true);

      migrationBuilder.AddColumn<string>(
          name: "Sessao",
          table: "Operador",
          type: "varchar(500)",
          nullable: true);

      // Drop foreign keys
      migrationBuilder.DropForeignKey(
          name: "FK_Viatura_Sessao_SessaoID",
          table: "Viatura");

      migrationBuilder.DropForeignKey(
          name: "FK_Operador_Sessao_SessaoID",
          table: "Operador");

      // Drop indexes
      migrationBuilder.DropIndex(
          name: "IX_Viatura_SessaoID",
          table: "Viatura");

      migrationBuilder.DropIndex(
          name: "IX_Operador_SessaoID",
          table: "Operador");

      // Drop SessaoID columns
      migrationBuilder.DropColumn(
          name: "SessaoID",
          table: "Viatura");

      migrationBuilder.DropColumn(
          name: "SessaoID",
          table: "Operador");
    }
  }
}
