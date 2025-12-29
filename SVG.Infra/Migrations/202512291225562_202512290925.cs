namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512290925 : DbMigration
  {
    public override void Up()
    {
      Sql(@"update Operacao set TipoOperacaoID = 4 where TipoOperacaoID = 5");
      Sql(@"delete from TipoOperacao where ID = 5");
    }

    public override void Down()
    {
    }
  }
}
