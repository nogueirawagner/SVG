namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202512091848 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operador", "Alcunha", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Operador", "Alcunha");
        }
    }
}
