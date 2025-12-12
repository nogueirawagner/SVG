namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202512112202 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operacao", "SvgAberto", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Operacao", "SvgAberto");
        }
    }
}
