using SVG.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.Extensions.Configuration;
using SVG.Domain.Entities.Identity;

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
    public DbSet<CalendarioPlantao> CalendarioPlantao { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<UsuarioRole> UsuarioRole { get; set; }

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

      modelBuilder.Entity<Usuario>()
        .HasOptional(u => u.Operador)      // Usuario pode NÃO ter Operador
        .WithOptionalDependent(o => o.Usuario)
        .Map(m => m.MapKey("OperadorID")); // Operador é dependente

      modelBuilder.Entity<CandidatoSVGOperacao>()
      .HasIndex(c => new { c.OperadorID, c.OperacaoID })
      .IsUnique();
    }
  }
}
