namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202602271750 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        IF NOT EXISTS (
            SELECT 1 
            FROM TipoOperacao 
            WHERE Nome = 'GDF'
        )
        BEGIN
            INSERT INTO TipoOperacao (Nome, Peso)
            VALUES ('GDF', 1);
        END;

        IF NOT EXISTS (
            SELECT 1 
            FROM TipoOperacao 
            WHERE Nome = 'Plan. Operacional'
        )
        BEGIN
            INSERT INTO TipoOperacao (Nome, Peso)
            VALUES ('Plan. Operacional', 1);
        END;

       IF NOT EXISTS (
            SELECT 1 
            FROM TipoOperacao 
            WHERE Nome = 'SOC'
        )
        BEGIN
            INSERT INTO TipoOperacao (Nome, Peso)
            VALUES ('SOC', 1);
        END;

        CREATE UNIQUE INDEX UX_TipoOperacao_Nome
        ON TipoOperacao (Nome);
        ");

      Sql(@"
         INSERT INTO DimTipoOperacao (TipoOperacaoID, Nome, Peso)
         SELECT
             t.ID,
             t.Nome,
             t.Peso
         FROM TipoOperacao t
         WHERE NOT EXISTS (
             SELECT 1
             FROM DimTipoOperacao d
             WHERE d.TipoOperacaoID = t.ID
         );
      ");
    }

    public override void Down()
    {
    }
  }
}
