namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202608241030 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operador", "NumericaSecao", c => c.Int(nullable: false));
            DropColumn("dbo.Operador", "NumericaSOR");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Operador", "NumericaSOR", c => c.Int(nullable: false));
            DropColumn("dbo.Operador", "NumericaSecao");
        }
    }
}
