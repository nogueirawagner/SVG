namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601181842 : DbMigration
  {
    public override void Up()
    {
      CreateTable(
          "dbo.Usuario",
          c => new
          {
            ID = c.Int(nullable: false, identity: true),
            Login = c.String(maxLength: 500, unicode: false),
            Nome = c.String(maxLength: 500, unicode: false),
            PasswordHash = c.String(maxLength: 500, unicode: false),
            Ativo = c.Boolean(nullable: false),
            OperadorID = c.Int(),
            Operador_ID = c.Int(),
          })
          .PrimaryKey(t => t.ID)
          .ForeignKey("dbo.Operador", t => t.Operador_ID)
          .Index(t => t.Operador_ID);

      CreateTable(
          "dbo.UsuarioRole",
          c => new
          {
            ID = c.Int(nullable: false, identity: true),
            UsuarioID = c.Int(nullable: false),
            RoleID = c.Int(nullable: false),
          })
          .PrimaryKey(t => t.ID)
          .ForeignKey("dbo.Role", t => t.RoleID)
          .ForeignKey("dbo.Usuario", t => t.UsuarioID)
          .Index(t => t.UsuarioID)
          .Index(t => t.RoleID);

      CreateTable(
          "dbo.Role",
          c => new
          {
            ID = c.Int(nullable: false, identity: true),
            Nome = c.String(maxLength: 500, unicode: false),
          })
          .PrimaryKey(t => t.ID);

    }

    public override void Down()
    {
      DropForeignKey("dbo.UsuarioRole", "UsuarioID", "dbo.Usuario");
      DropForeignKey("dbo.UsuarioRole", "RoleID", "dbo.Role");
      DropForeignKey("dbo.Usuario", "Operador_ID", "dbo.Operador");
      DropIndex("dbo.UsuarioRole", new[] { "RoleID" });
      DropIndex("dbo.UsuarioRole", new[] { "UsuarioID" });
      DropIndex("dbo.Usuario", new[] { "Operador_ID" });
      DropTable("dbo.Role");
      DropTable("dbo.UsuarioRole");
      DropTable("dbo.Usuario");
    }
  }
}
