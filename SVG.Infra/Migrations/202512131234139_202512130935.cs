namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202512130935 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OperadorOperacao", "Equipe");
            DropColumn("dbo.OperadorOperacao", "Funcao");
            DropColumn("dbo.OperadorOperacao", "Viatura");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OperadorOperacao", "Viatura", c => c.Int(nullable: false));
            AddColumn("dbo.OperadorOperacao", "Funcao", c => c.Int(nullable: false));
            AddColumn("dbo.OperadorOperacao", "Equipe", c => c.Int(nullable: false));
        }
    }
}
