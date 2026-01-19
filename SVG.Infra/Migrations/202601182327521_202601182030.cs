namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601182030 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        IF NOT EXISTS (SELECT 1 FROM dbo.Role WHERE Nome = 'Admin')
        BEGIN
            INSERT INTO dbo.Role (Nome)
            VALUES ('Admin');
        END

        IF NOT EXISTS (SELECT 1 FROM dbo.Role WHERE Nome = 'Operador')
        BEGIN
            INSERT INTO dbo.Role (Nome)
            VALUES ('Operador');
        END
      ");
    }

    public override void Down()
    {
    }
  }
}
