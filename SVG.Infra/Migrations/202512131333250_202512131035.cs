namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202512131035 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Operacao", "DP");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Operacao", "DP", c => c.String(maxLength: 500, unicode: false));
        }
    }
}
