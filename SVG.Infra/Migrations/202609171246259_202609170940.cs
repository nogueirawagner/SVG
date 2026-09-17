namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202609170940 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Viatura", "OperadorResponsavelID");
            RenameColumn(table: "dbo.Viatura", name: "Operador_ID", newName: "OperadorResponsavelID");
            RenameIndex(table: "dbo.Viatura", name: "IX_Operador_ID", newName: "IX_OperadorResponsavelID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Viatura", name: "IX_OperadorResponsavelID", newName: "IX_Operador_ID");
            RenameColumn(table: "dbo.Viatura", name: "OperadorResponsavelID", newName: "Operador_ID");
            AddColumn("dbo.Viatura", "OperadorResponsavelID", c => c.Int());
        }
    }
}
