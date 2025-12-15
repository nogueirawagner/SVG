namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512131035 : DbMigration
  {
    public override void Up()
    {
      DropColumn("dbo.Operacao", "DP");

      Sql(@"
      SET IDENTITY_INSERT [dbo].[TipoOperacao] ON 
      INSERT [dbo].[TipoOperacao] ([ID], [Nome], [Peso]) VALUES (1, N'Apoio', 5)
      INSERT [dbo].[TipoOperacao] ([ID], [Nome], [Peso]) VALUES (2, N'Alvorada', 2)
      INSERT [dbo].[TipoOperacao] ([ID], [Nome], [Peso]) VALUES (3, N'Delta', 3)
      INSERT [dbo].[TipoOperacao] ([ID], [Nome], [Peso]) VALUES (4, N'Segurança Orgânica', 1)
      INSERT [dbo].[TipoOperacao] ([ID], [Nome], [Peso]) VALUES (5, N'Reforço Plantão', 3)
      SET IDENTITY_INSERT [dbo].[TipoOperacao] OFF
      ");
    }

    public override void Down()
    {
      AddColumn("dbo.Operacao", "DP", c => c.String(maxLength: 500, unicode: false));
    }
  }
}
