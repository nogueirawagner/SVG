using SVG.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.Extensions.Configuration;

namespace SVG.Infra.Context.SQLServer
{
  public class SQLServerContext : DbContext, ISQLServerContext
  {
    
#if DEBUG
    static string connectionName = "ConnectionLocal";
#else
        static string connectionName = "ConnectionProduction_Az";
#endif

    public SQLServerContext()
      : base("name=" + connectionName)
    {
      Configuration.ProxyCreationEnabled = false;
      Configuration.LazyLoadingEnabled = true;
    }

    // Add-Migration 202512161200 -Project SVG.Infra -StartupProject SVG.WebApp
    // Update-Database -v -Project SVG.Infra -StartupProject SVG.WebApp

    #region objetos
    public DbSet<Operador> Operador { get; set; }
    public DbSet<Operacao> Operacao { get; set; }
    public DbSet<OperadorOperacao> OperadorOperacao { get; set; }
    public DbSet<Sessao> Sessao { get; set; }
    public DbSet<Viatura> Viatura { get; set; }
    public DbSet<ViaturaOperacao> ViaturaOperacao { get; set; }
    public DbSet<TipoOperacao> TipoOperacoes { get; set; }
    public DbSet<CandidatoSVGOperacao> CandidatoSVGOperacao { get; set; }

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
    }
  }
}
