namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202609112355 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ViaturaMovimentacao",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ViaturaID = c.Int(nullable: false),
                        OperadorID = c.Int(nullable: false),
                        DataHora = c.DateTime(nullable: false),
                        Finalidade = c.Int(nullable: false),
                        Situacao = c.Int(nullable: false),
                        DataHoraRetirada = c.DateTime(nullable: false),
                        DataHoraDevolucao = c.DateTime(),
                        KmInicial = c.Int(nullable: false),
                        KmFinal = c.Int(),
                        Observacao = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Operador", t => t.OperadorID)
                .ForeignKey("dbo.Viatura", t => t.ViaturaID)
                .Index(t => t.ViaturaID)
                .Index(t => t.OperadorID);
            
            AddColumn("dbo.Viatura", "Marca", c => c.String(maxLength: 500, unicode: false));
            AddColumn("dbo.Viatura", "Ano", c => c.Int());
            AddColumn("dbo.Viatura", "OperadorResponsavelID", c => c.Int());
            AddColumn("dbo.Viatura", "TipoCaracterizacao", c => c.Int(nullable: false));
            AddColumn("dbo.Viatura", "QuilometragemAtual", c => c.Int(nullable: false));
            AddColumn("dbo.Viatura", "Situacao", c => c.Int(nullable: false));
            AddColumn("dbo.Viatura", "Operador_ID", c => c.Int());
            CreateIndex("dbo.Viatura", "Operador_ID");
            AddForeignKey("dbo.Viatura", "Operador_ID", "dbo.Operador", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Viatura", "Operador_ID", "dbo.Operador");
            DropForeignKey("dbo.ViaturaMovimentacao", "ViaturaID", "dbo.Viatura");
            DropForeignKey("dbo.ViaturaMovimentacao", "OperadorID", "dbo.Operador");
            DropIndex("dbo.ViaturaMovimentacao", new[] { "OperadorID" });
            DropIndex("dbo.ViaturaMovimentacao", new[] { "ViaturaID" });
            DropIndex("dbo.Viatura", new[] { "Operador_ID" });
            DropColumn("dbo.Viatura", "Operador_ID");
            DropColumn("dbo.Viatura", "Situacao");
            DropColumn("dbo.Viatura", "QuilometragemAtual");
            DropColumn("dbo.Viatura", "TipoCaracterizacao");
            DropColumn("dbo.Viatura", "OperadorResponsavelID");
            DropColumn("dbo.Viatura", "Ano");
            DropColumn("dbo.Viatura", "Marca");
            DropTable("dbo.ViaturaMovimentacao");
        }
    }
}
