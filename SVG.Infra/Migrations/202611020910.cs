using System.Data.Entity.Migrations;

namespace SVG.Infra.Migrations
{
  public partial class _202611020910 : DbMigration
  {
    public override void Up()
    {
      // NULL preserva o significado de registros antigos: nível não informado.
      AddColumn("dbo.ViaturaMovimentacao", "NivelCombustivelRetirada", c => c.Int());
      AddColumn("dbo.ViaturaMovimentacao", "NivelCombustivelDevolucao", c => c.Int());
      Sql("ALTER TABLE dbo.ViaturaMovimentacao ADD CONSTRAINT CK_ViaturaMovimentacao_CombustivelRetirada CHECK (NivelCombustivelRetirada BETWEEN 0 AND 100)");
      Sql("ALTER TABLE dbo.ViaturaMovimentacao ADD CONSTRAINT CK_ViaturaMovimentacao_CombustivelDevolucao CHECK (NivelCombustivelDevolucao BETWEEN 0 AND 100)");
    }

    public override void Down()
    {
      Sql("ALTER TABLE dbo.ViaturaMovimentacao DROP CONSTRAINT CK_ViaturaMovimentacao_CombustivelDevolucao");
      Sql("ALTER TABLE dbo.ViaturaMovimentacao DROP CONSTRAINT CK_ViaturaMovimentacao_CombustivelRetirada");
      DropColumn("dbo.ViaturaMovimentacao", "NivelCombustivelDevolucao");
      DropColumn("dbo.ViaturaMovimentacao", "NivelCombustivelRetirada");
    }
  }
}
