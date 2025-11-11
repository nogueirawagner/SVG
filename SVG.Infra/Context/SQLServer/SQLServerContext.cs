using System.Data.Entity;
using SVG.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using SVG.Infra.EntityConfig;

namespace SVG.Infra.Context.SQLServer
{
  public class SQLServerContext : DbContext, ISQLServerContext
  {
    public SQLServerContext()
        : base("ConnectionLocal")
    {
      Configuration.ProxyCreationEnabled = false;
      Configuration.LazyLoadingEnabled = true;
    }

    #region objetos
    public DbSet<Operador> Operador { get; set; }

    #endregion


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
      modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

      modelBuilder.Properties().Where(s => s.Name == s.ReflectedType.Name + "Id"
          || s.Name == s.ReflectedType.Name + "ID")
          .Configure(s => s.IsKey());

      modelBuilder.Properties<string>()
          .Configure(p => p.HasColumnType("varchar"));

      modelBuilder.Properties<string>()
          .Configure(p => p.HasMaxLength(500));


      #region ArquivoConfiguracao
      modelBuilder.Configurations.Add(new OperadorConfiguration());
      #endregion
    }
  }
}
