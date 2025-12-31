namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512290925 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        WHILE 1=1
        BEGIN
            UPDATE TOP (100) dbo.Operacao
            SET TipoOperacaoID = 4
            WHERE TipoOperacaoID = 5;

            IF @@ROWCOUNT = 0 BREAK;
        END
        ");

      Sql(@"
        IF NOT EXISTS (SELECT 1 FROM dbo.Operacao WHERE TipoOperacaoID = 5)
        BEGIN
            DELETE FROM dbo.TipoOperacao WHERE ID = 5;
        END
      ");
    }

    public override void Down()
    {
    }
  }
}
