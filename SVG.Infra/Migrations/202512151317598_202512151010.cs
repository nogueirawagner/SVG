namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512151010 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
      IF NOT EXISTS (SELECT 1 FROM [dbo].TipoOperacao WHERE Nome = 'Reforço Plantão')
       BEGIN
           insert into TipoOperacao (Nome, Peso) values ('Reforço Plantão', '3')
       END
      ");
    }

    public override void Down()
    {
    }
  }
}
