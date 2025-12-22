namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202512221135 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Operacao", "DataHoraInicio", c => c.DateTime());
            AlterColumn("dbo.Operacao", "DataHoraFim", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Operacao", "DataHoraFim", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Operacao", "DataHoraInicio", c => c.DateTime(nullable: false));
        }
    }
}
