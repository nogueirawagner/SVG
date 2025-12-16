using SVG.Domain.Entities;
using SVG.Infra.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.Extensions.Configuration;

namespace SVG.Infra.Context.SQLServer
{
  public class SQLServerContext : DbContext, ISQLServerContext
  {
    // ctor default para ser encontrado por reflexão
    public SQLServerContext(string cs)
      : base(cs)
    {
      Configuration.ProxyCreationEnabled = false;
      Configuration.LazyLoadingEnabled = true;
    }

    #region objetos
    public DbSet<Operador> Operador { get; set; }
    public DbSet<Operacao> Operacao { get; set; }
    public DbSet<OperadorOperacao> OperadorOperacao { get; set; }
    public DbSet<Sessao> Sessao { get; set; }
    public DbSet<Viatura> Viatura { get; set; }
    public DbSet<ViaturaOperacao> ViaturaOperacao { get; set; }
    public DbSet<TipoOperacao> TipoOperacoes { get; set; }

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
