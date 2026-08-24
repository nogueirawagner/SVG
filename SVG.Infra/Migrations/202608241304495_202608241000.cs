namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202608241000 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operador", "DataIngressoDOE", c => c.DateTime());
            AddColumn("dbo.Operador", "NumericaDOE", c => c.Int(nullable: false));
            AddColumn("dbo.Operador", "NumericaSOR", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Operador", "NumericaSOR");
            DropColumn("dbo.Operador", "NumericaDOE");
            DropColumn("dbo.Operador", "DataIngressoDOE");
        }
    }
}
