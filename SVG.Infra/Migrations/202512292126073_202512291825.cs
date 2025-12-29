namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202512291825 : DbMigration
  {
    public override void Up()
    {
      Sql(@"CREATE UNIQUE INDEX UX_CandidatoSVGOperacao_Operador_Operacao
            ON CandidatoSVGOperacao (OperadorID, OperacaoID);
        ");
    }

    public override void Down()
    {
    }
  }
}
