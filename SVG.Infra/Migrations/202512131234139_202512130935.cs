namespace SVG.Infra.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;
    
    public partial class _202512130935 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Equipe",
                table: "OperadorOperacao",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "Funcao",
                table: "OperadorOperacao",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "Viatura",
                table: "OperadorOperacao",
                schema: "dbo");
        }
        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Viatura",
                table: "OperadorOperacao",
                schema: "dbo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Funcao",
                table: "OperadorOperacao",
                schema: "dbo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Equipe",
                table: "OperadorOperacao",
                schema: "dbo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
