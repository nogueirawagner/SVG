namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202512151200 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Operacao", "QtdEquipe");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Operacao", "QtdEquipe", c => c.Int(nullable: false));
        }
    }
}
