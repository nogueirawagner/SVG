namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512151010 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"
      IF NOT EXISTS (SELECT 1 FROM [dbo].TipoOperacao WHERE Nome = 'Reforço Plantão')
       BEGIN
           insert into TipoOperacao (Nome, Peso) values ('Reforço Plantão', '3')
       END
      ");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
    }
  }
}
