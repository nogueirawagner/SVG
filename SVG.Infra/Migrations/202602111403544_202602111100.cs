namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202602111100 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.CandidatoSVGOperacao", new[] { "OperadorID", "OperacaoID" }, unique: true);
            AddForeignKey("dbo.CandidatoSVGOperacao", "OperacaoID", "dbo.Operacao", "ID");
            AddForeignKey("dbo.CandidatoSVGOperacao", "OperadorID", "dbo.Operador", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CandidatoSVGOperacao", "OperadorID", "dbo.Operador");
            DropForeignKey("dbo.CandidatoSVGOperacao", "OperacaoID", "dbo.Operacao");
            DropIndex("dbo.CandidatoSVGOperacao", new[] { "OperadorID", "OperacaoID" });
        }
    }
}
