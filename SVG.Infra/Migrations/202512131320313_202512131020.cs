namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202512131020 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operacao", "OrdemServico", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Operacao", "OrdemServico");
        }
    }
}
