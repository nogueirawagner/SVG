namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipe",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Operacao",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        Objeto = c.String(maxLength: 500, unicode: false),
                        DP = c.String(maxLength: 500, unicode: false),
                        Coordenador = c.String(maxLength: 500, unicode: false),
                        QtdEquipe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OperadorOperacao",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OperacaoID = c.Int(nullable: false),
                        OperadorID = c.Int(nullable: false),
                        SVG = c.Boolean(nullable: false),
                        Equipe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Operacao", t => t.OperacaoID)
                .ForeignKey("dbo.Operador", t => t.OperadorID)
                .Index(t => t.OperacaoID)
                .Index(t => t.OperadorID);
            
            CreateTable(
                "dbo.ViaturaOperacao",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ViaturaID = c.Int(nullable: false),
                        OperacaoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Operacao", t => t.OperacaoID)
                .ForeignKey("dbo.Viatura", t => t.ViaturaID)
                .Index(t => t.ViaturaID)
                .Index(t => t.OperacaoID);
            
            CreateTable(
                "dbo.Viatura",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Modelo = c.String(maxLength: 500, unicode: false),
                        Prefixo = c.String(maxLength: 500, unicode: false),
                        Placa = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ViaturaOperacao", "ViaturaID", "dbo.Viatura");
            DropForeignKey("dbo.ViaturaOperacao", "OperacaoID", "dbo.Operacao");
            DropForeignKey("dbo.OperadorOperacao", "OperadorID", "dbo.Operador");
            DropForeignKey("dbo.OperadorOperacao", "OperacaoID", "dbo.Operacao");
            DropIndex("dbo.ViaturaOperacao", new[] { "OperacaoID" });
            DropIndex("dbo.ViaturaOperacao", new[] { "ViaturaID" });
            DropIndex("dbo.OperadorOperacao", new[] { "OperadorID" });
            DropIndex("dbo.OperadorOperacao", new[] { "OperacaoID" });
            DropTable("dbo.Viatura");
            DropTable("dbo.ViaturaOperacao");
            DropTable("dbo.OperadorOperacao");
            DropTable("dbo.Operacao");
            DropTable("dbo.Equipe");
        }
    }
}
