namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512131035 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropColumn(
      name: "DP",
      table: "Operacao",
      schema: "dbo");

      migrationBuilder.Sql(@"
       SET IDENTITY_INSERT [dbo].[TipoOperacao] ON 
       INSERT [dbo].[TipoOperacao] ([ID], [Nome], [Peso]) VALUES (1, N'Apoio',5)
       INSERT [dbo].[TipoOperacao] ([ID], [Nome], [Peso]) VALUES (2, N'Alvorada',2)
       INSERT [dbo].[TipoOperacao] ([ID], [Nome], [Peso]) VALUES (3, N'Delta',3)
       INSERT [dbo].[TipoOperacao] ([ID], [Nome], [Peso]) VALUES (4, N'Segurança Orgânica',1)
       INSERT [dbo].[TipoOperacao] ([ID], [Nome], [Peso]) VALUES (5, N'Reforço Plantão',3)
       SET IDENTITY_INSERT [dbo].[TipoOperacao] OFF
       ");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AddColumn<string>(
      name: "DP",
      table: "Operacao",
      schema: "dbo",
      type: "varchar(500)",
      maxLength: 500,
      nullable: true);
    }
  }
}
