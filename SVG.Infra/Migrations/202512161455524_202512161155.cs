namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512161155 : DbMigration
  {
    public override void Up()
    {
      Sql(@"update OperadorOperacao set SVG = 1");
    }

    public override void Down()
    {
    }
  }
}
