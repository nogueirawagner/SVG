namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202511181730 : DbMigration
  {
    public override void Up()
    {
      AddColumn("dbo.Operador", "SessaoID", c => c.Int(nullable: false));
      AddColumn("dbo.Viatura", "SessaoID", c => c.Int(nullable: false));
      CreateIndex("dbo.Operador", "SessaoID");
      CreateIndex("dbo.Viatura", "SessaoID");
      AddForeignKey("dbo.Operador", "SessaoID", "dbo.Sessao", "ID");
      AddForeignKey("dbo.Viatura", "SessaoID", "dbo.Sessao", "ID");
      DropColumn("dbo.Operador", "Sessao");
      DropColumn("dbo.Viatura", "Equipe");
    }

    public override void Down()
    {
      AddColumn("dbo.Viatura", "Equipe", c => c.String(maxLength: 500, unicode: false));
      AddColumn("dbo.Operador", "Sessao", c => c.String(maxLength: 500, unicode: false));
      DropForeignKey("dbo.Viatura", "SessaoID", "dbo.Sessao");
      DropForeignKey("dbo.Operador", "SessaoID", "dbo.Sessao");
      DropIndex("dbo.Viatura", new[] { "SessaoID" });
      DropIndex("dbo.Operador", new[] { "SessaoID" });
      DropColumn("dbo.Viatura", "SessaoID");
      DropColumn("dbo.Operador", "SessaoID");
    }
  }
}
