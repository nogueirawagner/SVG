namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601091125 : DbMigration
  {
    public override void Up()
    {
      CreateTable(
          "dbo.CalendarioPlantao",
          c => new
          {
            ID = c.Int(nullable: false, identity: true),
            SecaoID = c.Int(nullable: false),
            UltimoPlantao = c.DateTime(nullable: false),
          })
          .PrimaryKey(t => t.ID)
          .ForeignKey("dbo.Sessao", t => t.SecaoID)
          .Index(t => t.SecaoID);
    }

    public override void Down()
    {
      DropForeignKey("dbo.CalendarioPlantao", "SecaoID", "dbo.Sessao");
      DropIndex("dbo.CalendarioPlantao", new[] { "SecaoID" });
      DropTable("dbo.CalendarioPlantao");
    }
  }
}
