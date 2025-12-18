namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512181206 : DbMigration
  {
    public override void Up()
    {
      AddColumn("dbo.Operacao", "QtdVagasRestantes", c => c.Int(nullable: false));
    }

    public override void Down()
    {
      DropColumn("dbo.Operacao", "QtdVagasRestantes");
    }
  }
}
