namespace SVG.Infra.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class _202611081137 : DbMigration
    {
        public override void Up()
        {
            // Anexos anteriores permanecem sem subgrupo; nenhuma classificação é inferida.
            Sql(@"IF COL_LENGTH(N'dbo.AnexoPlanejamento', N'Subgrupo') IS NULL
    ALTER TABLE dbo.AnexoPlanejamento ADD Subgrupo int NULL;");
            Sql(@"IF COL_LENGTH(N'dbo.AnexoPlanejamento', N'Ordem') IS NULL
    ALTER TABLE dbo.AnexoPlanejamento ADD Ordem int NOT NULL CONSTRAINT DF_AnexoPlanejamento_Ordem DEFAULT (0) WITH VALUES;");
            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE parent_object_id=OBJECT_ID(N'dbo.AnexoPlanejamento') AND name=N'CK_AnexoPlanejamento_Subgrupo')
    ALTER TABLE dbo.AnexoPlanejamento ADD CONSTRAINT CK_AnexoPlanejamento_Subgrupo CHECK (Subgrupo IS NULL OR Subgrupo IN (1,2,3,4));");
            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE parent_object_id=OBJECT_ID(N'dbo.AnexoPlanejamento') AND name=N'CK_AnexoPlanejamento_Ordem')
    ALTER TABLE dbo.AnexoPlanejamento ADD CONSTRAINT CK_AnexoPlanejamento_Ordem CHECK (Ordem >= 0);");
        }

        public override void Down()
        {
            Sql(@"IF EXISTS (SELECT 1 FROM sys.check_constraints WHERE parent_object_id=OBJECT_ID(N'dbo.AnexoPlanejamento') AND name=N'CK_AnexoPlanejamento_Subgrupo')
    ALTER TABLE dbo.AnexoPlanejamento DROP CONSTRAINT CK_AnexoPlanejamento_Subgrupo;");
            Sql(@"IF EXISTS (SELECT 1 FROM sys.check_constraints WHERE parent_object_id=OBJECT_ID(N'dbo.AnexoPlanejamento') AND name=N'CK_AnexoPlanejamento_Ordem')
    ALTER TABLE dbo.AnexoPlanejamento DROP CONSTRAINT CK_AnexoPlanejamento_Ordem;");
            Sql(@"IF EXISTS (SELECT 1 FROM sys.default_constraints WHERE parent_object_id=OBJECT_ID(N'dbo.AnexoPlanejamento') AND name=N'DF_AnexoPlanejamento_Ordem')
    ALTER TABLE dbo.AnexoPlanejamento DROP CONSTRAINT DF_AnexoPlanejamento_Ordem;");
            Sql(@"IF COL_LENGTH(N'dbo.AnexoPlanejamento', N'Ordem') IS NOT NULL
    ALTER TABLE dbo.AnexoPlanejamento DROP COLUMN Ordem;");
            Sql(@"IF COL_LENGTH(N'dbo.AnexoPlanejamento', N'Subgrupo') IS NOT NULL
    ALTER TABLE dbo.AnexoPlanejamento DROP COLUMN Subgrupo;");
        }
    }
}
