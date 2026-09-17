namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202609151610 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Operacao", "Objeto", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Operacao", "OrdemServico", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.TipoOperacao", "Nome", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TipoOperacao", "Nome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Operacao", "OrdemServico", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Operacao", "Objeto", c => c.String(maxLength: 100, unicode: false));
        }
    }
}
