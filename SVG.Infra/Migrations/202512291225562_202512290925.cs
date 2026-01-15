namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202512290925 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"
        WHILE 1=1
        BEGIN
            UPDATE TOP (100) dbo.Operacao
            SET TipoOperacaoID = 4
            WHERE TipoOperacaoID = 5;

            IF @@ROWCOUNT = 0 BREAK;
        END
        ");

      migrationBuilder.Sql(@"
        IF NOT EXISTS (SELECT 1 FROM dbo.Operacao WHERE TipoOperacaoID = 5)
        BEGIN
            DELETE FROM dbo.TipoOperacao WHERE ID = 5;
        END
      ");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
    }
  }
}
