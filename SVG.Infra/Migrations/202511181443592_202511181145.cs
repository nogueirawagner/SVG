using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SVG.Infra.Migrations
{
  public partial class _202511181145 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      // Rename table Equipe -> Sessao
      migrationBuilder.RenameTable(
          name: "Equipe",
          newName: "Sessao");

      // OperadorOperacao
      migrationBuilder.AddColumn<int>(
          name: "Funcao",
          table: "OperadorOperacao",
          type: "int",
          nullable: false,
          defaultValue: 0);

      migrationBuilder.AddColumn<int>(
          name: "Viatura",
          table: "OperadorOperacao",
          type: "int",
          nullable: false,
          defaultValue: 0);

      // Operador
      migrationBuilder.AddColumn<string>(
          name: "Telefone",
          table: "Operador",
          type: "varchar(500)",
          nullable: true);

      // Viatura
      migrationBuilder.AddColumn<string>(
          name: "Equipe",
          table: "Viatura",
          type: "varchar(500)",
          nullable: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
          name: "Equipe",
          table: "Viatura");

      migrationBuilder.DropColumn(
          name: "Telefone",
          table: "Operador");

      migrationBuilder.DropColumn(
          name: "Viatura",
          table: "OperadorOperacao");

      migrationBuilder.DropColumn(
          name: "Funcao",
          table: "OperadorOperacao");

      migrationBuilder.RenameTable(
          name: "Sessao",
          newName: "Equipe");
    }
  }
}
