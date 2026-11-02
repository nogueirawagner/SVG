namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202611020920 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ViaturaMovimentacao", "OperadorResponsavelID", c => c.Int());
            CreateIndex("dbo.ViaturaMovimentacao", "OperadorResponsavelID");
            AddForeignKey("dbo.ViaturaMovimentacao", "OperadorResponsavelID", "dbo.Operador", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ViaturaMovimentacao", "OperadorResponsavelID", "dbo.Operador");
            DropIndex("dbo.ViaturaMovimentacao", new[] { "OperadorResponsavelID" });
            DropColumn("dbo.ViaturaMovimentacao", "OperadorResponsavelID");
        }
    }
}
