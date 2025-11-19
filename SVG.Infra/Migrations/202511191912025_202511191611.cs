namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202511191611 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoOperacao",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 500, unicode: false),
                        Peso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Operacao", "TipoOperacaoID", c => c.Int(nullable: false));
            CreateIndex("dbo.Operacao", "TipoOperacaoID");
            AddForeignKey("dbo.Operacao", "TipoOperacaoID", "dbo.TipoOperacao", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Operacao", "TipoOperacaoID", "dbo.TipoOperacao");
            DropIndex("dbo.Operacao", new[] { "TipoOperacaoID" });
            DropColumn("dbo.Operacao", "TipoOperacaoID");
            DropTable("dbo.TipoOperacao");
        }
    }
}
