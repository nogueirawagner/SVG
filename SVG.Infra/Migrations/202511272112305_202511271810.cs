namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202511271810 : DbMigration
  {
    public override void Up()
    {
      AddColumn("dbo.Operacao", "DataHoraCriacao", c => c.DateTime(nullable: false));
    }

    public override void Down()
    {
      DropColumn("dbo.Operacao", "DataHoraCriacao");
    }
  }
}
