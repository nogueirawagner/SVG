namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601051155 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        CREATE FULLTEXT INDEX ON dbo.Operacao
        (
            OrdemServico LANGUAGE 1046,
	          Objeto LANGUAGE 1046
        )
        KEY INDEX [PK_dbo.Operacao]
        WITH (STOPLIST = SYSTEM);
      ");
    }

    public override void Down()
    {
    }
  }
}
