namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<SVG.Infra.Context.SQLServer.SQLServerContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(SVG.Infra.Context.SQLServer.SQLServerContext context)
    {
    }
  }
}
