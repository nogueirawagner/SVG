namespace SVG.Infra.Migrations
{
  using System;
  using Microsoft.EntityFrameworkCore.Migrations;

  public partial class _202601051155 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql(@"
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

    protected override void Down(MigrationBuilder migrationBuilder)
    {
    }
  }
}
