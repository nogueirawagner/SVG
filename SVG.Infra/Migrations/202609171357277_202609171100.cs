namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202609171100 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ViaturaMovimentacao", "DataHora");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ViaturaMovimentacao", "DataHora", c => c.DateTime(nullable: false));
        }
    }
}
