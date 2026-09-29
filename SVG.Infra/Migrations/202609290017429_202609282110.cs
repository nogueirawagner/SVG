namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202609282110 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImpedimentoOperador",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OperadorID = c.Int(nullable: false),
                        TipoImpedimento = c.Int(nullable: false),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(),
                        Observacao = c.String(maxLength: 100, unicode: false),
                        DataHoraCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Operador", t => t.OperadorID)
                .Index(t => t.OperadorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImpedimentoOperador", "OperadorID", "dbo.Operador");
            DropIndex("dbo.ImpedimentoOperador", new[] { "OperadorID" });
            DropTable("dbo.ImpedimentoOperador");
        }
    }
}
