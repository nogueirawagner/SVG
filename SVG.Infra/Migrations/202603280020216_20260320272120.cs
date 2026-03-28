namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20260320272120 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operacao", "QtdVagasTotais", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Operacao", "QtdVagasTotais");
        }
    }
}
