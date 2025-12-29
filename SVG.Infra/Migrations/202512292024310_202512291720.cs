namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512291720 : DbMigration
  {
    public override void Up()
    {
      CreateTable(
          "dbo.CandidatoSVGOperacao",
          c => new
          {
            ID = c.Int(nullable: false, identity: true),
            OperadorID = c.Int(nullable: false),
            OperacaoID = c.Int(nullable: false),
            DataHoraCriacao = c.DateTime(nullable: false),
          })
          .PrimaryKey(t => t.ID);

    }

    public override void Down()
    {
      DropTable("dbo.CandidatoSVGOperacao");
    }
  }
}
