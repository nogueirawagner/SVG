namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202611061700 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planejamento", "MBA", c => c.Boolean(nullable: false));
            AddColumn("dbo.Planejamento", "MP", c => c.Boolean(nullable: false));
            AddColumn("dbo.Planejamento", "NumeroMBA", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planejamento", "NumeroMBA");
            DropColumn("dbo.Planejamento", "MP");
            DropColumn("dbo.Planejamento", "MBA");
        }
    }
}
