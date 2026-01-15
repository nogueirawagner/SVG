namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202601091125 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
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

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      DropForeignKey("dbo.CalendarioPlantao", "SecaoID", "dbo.Sessao");
      DropIndex("dbo.CalendarioPlantao", new[] { "SecaoID" });
      DropTable("dbo.CalendarioPlantao");
    }
  }
}
