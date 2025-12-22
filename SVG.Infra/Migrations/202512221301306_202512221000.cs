namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202512221000 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operacao", "DataHoraInicio", c => c.DateTime(nullable: false));
            AddColumn("dbo.Operacao", "DataHoraFim", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Operacao", "DataHoraFim");
            DropColumn("dbo.Operacao", "DataHoraInicio");
        }
    }
}
