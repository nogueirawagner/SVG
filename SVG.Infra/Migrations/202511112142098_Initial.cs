namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class Initial : DbMigration
  {
    public override void Up()
    {
      CreateTable(
          "dbo.Operador",
          c => new
          {
            ID = c.Int(nullable: false, identity: true),
            Matricula = c.String(maxLength: 500, unicode: false),
            Nome = c.String(maxLength: 500, unicode: false),
            Sessao = c.String(maxLength: 500, unicode: false),
          })
          .PrimaryKey(t => t.ID);

    }

    public override void Down()
    {
      DropTable("dbo.Operador");
    }
  }
}
