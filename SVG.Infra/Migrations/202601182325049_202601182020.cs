namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202601182020 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuario", "OperadorID");
            RenameColumn(table: "dbo.Usuario", name: "Operador_ID", newName: "OperadorID");
            RenameIndex(table: "dbo.Usuario", name: "IX_Operador_ID", newName: "IX_OperadorID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Usuario", name: "IX_OperadorID", newName: "IX_Operador_ID");
            RenameColumn(table: "dbo.Usuario", name: "OperadorID", newName: "Operador_ID");
            AddColumn("dbo.Usuario", "OperadorID", c => c.Int());
        }
    }
}
