namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202511181145 : DbMigration
  {
    public override void Up()
    {
      RenameTable(name: "dbo.Equipe", newName: "Sessao");
      AddColumn("dbo.OperadorOperacao", "Funcao", c => c.Int(nullable: false));
      AddColumn("dbo.OperadorOperacao", "Viatura", c => c.Int(nullable: false));
      AddColumn("dbo.Operador", "Telefone", c => c.String(maxLength: 500, unicode: false));
      AddColumn("dbo.Viatura", "Equipe", c => c.String(maxLength: 500, unicode: false));
    }

    public override void Down()
    {
      DropColumn("dbo.Viatura", "Equipe");
      DropColumn("dbo.Operador", "Telefone");
      DropColumn("dbo.OperadorOperacao", "Viatura");
      DropColumn("dbo.OperadorOperacao", "Funcao");
      RenameTable(name: "dbo.Sessao", newName: "Equipe");
    }
  }
}
