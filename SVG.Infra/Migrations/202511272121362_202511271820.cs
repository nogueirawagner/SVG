namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202511271820 : DbMigration
  {
    public override void Up()
    {
      Sql(@"UPDATE Operacao SET DataHoraCriacao = GETDATE()");
    }

    public override void Down()
    {
    }
  }
}
