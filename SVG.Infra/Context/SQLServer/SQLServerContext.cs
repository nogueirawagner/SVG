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

    //#if DEBUG
    //    static string cs = "Data Source=DESKTOP-3MKU8HI;Initial Catalog=SVG;Persist Security Info=True;User ID=sa;Password=_senhas_2012;MultipleActiveResultSets=True";
    //#else
    //    static string cs = "Data Source=doepcdf.database.windows.net;Initial Catalog=DOE;Persist Security Info=True;User ID=doe_app;Password=_senhas_2012;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True";
    //#endif

    static string cs = "Data Source=DESKTOP-3MKU8HI;Initial Catalog=SVG;Persist Security Info=True;User ID=sa;Password=_senhas_2012;MultipleActiveResultSets=True";

    //static string cs = "Data Source=doepcdf.database.windows.net;Initial Catalog=DOE;Persist Security Info=True;User ID=doe_app;Password=_senhas_2012;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True";

    // ctor default para ser encontrado por reflexão
    public SQLServerContext()
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
