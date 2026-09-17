namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202609151900 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Viatura", "KmAtual", c => c.Int(nullable: false));
            AddColumn("dbo.Viatura", "KmUltimoAbastecimento", c => c.Int());
            AddColumn("dbo.Viatura", "KmProximaRevisao", c => c.Int());
            AddColumn("dbo.Viatura", "Chassi", c => c.String(maxLength: 17, unicode: false));
            AddColumn("dbo.ViaturaMovimentacao", "KmAbastecimento", c => c.Int());
            AddColumn("dbo.ViaturaMovimentacao", "Abastecimento", c => c.Boolean(nullable: false));
            DropColumn("dbo.Viatura", "QuilometragemAtual");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Viatura", "QuilometragemAtual", c => c.Int(nullable: false));
            DropColumn("dbo.ViaturaMovimentacao", "Abastecimento");
            DropColumn("dbo.ViaturaMovimentacao", "KmAbastecimento");
            DropColumn("dbo.Viatura", "Chassi");
            DropColumn("dbo.Viatura", "KmProximaRevisao");
            DropColumn("dbo.Viatura", "KmUltimoAbastecimento");
            DropColumn("dbo.Viatura", "KmAtual");
        }
    }
}
