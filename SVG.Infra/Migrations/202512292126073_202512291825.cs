namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512291825 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"CREATE UNIQUE INDEX UX_CandidatoSVGOperacao_Operador_Operacao
            ON CandidatoSVGOperacao (OperadorID, OperacaoID);
        ");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
    }
  }
}
