namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601051155 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
      IF NOT EXISTS (
          SELECT 1
          FROM sys.fulltext_indexes fi
          WHERE fi.object_id = OBJECT_ID('dbo.Operacao')
      )
      BEGIN
          CREATE FULLTEXT INDEX ON dbo.Operacao
          (
              OrdemServico LANGUAGE 1046,
              Objeto        LANGUAGE 1046
          )
          KEY INDEX [PK_dbo.Operacao]
          WITH (STOPLIST = SYSTEM);
      END
      ");
    }

    public override void Down()
    {
    }
  }
}
