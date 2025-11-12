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
    public SQLServerContext(string cs)
      : base(cs)
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

  public class SQLServerContextFactory : IDbContextFactory<SQLServerContext>
  {
    public SQLServerContext Create()
    {
      // Ajuste este nome se seu projeto web tiver outro nome
      var webProjectName = "SVG.WebApp";

      // Sobe 3 níveis da pasta bin/Debug/net48/... até a pasta da solution
      var baseDir = AppDomain.CurrentDomain.BaseDirectory;

      string[] candidatePaths =
        {
            Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", "..", webProjectName)),
            Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", webProjectName)),
            Path.GetFullPath(Path.Combine(baseDir, "..", "..", webProjectName))
        };

      var webDir = candidatePaths.FirstOrDefault(Directory.Exists);
      if (webDir == null)
      {
        throw new DirectoryNotFoundException(
            "Não encontrei a pasta do projeto web. " +
            "Tente ajustar o nome do projeto em 'webProjectName' ou revise o layout da solução.\n" +
            string.Join("\nTentativas: ", candidatePaths)
        );
      }


      var config = new ConfigurationBuilder()
          .SetBasePath(webDir)
          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
          .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: false)
          .AddEnvironmentVariables()
          .Build();

      var cs = config.GetConnectionString("ConnectionLocal");
      if (string.IsNullOrWhiteSpace(cs))
        throw new InvalidOperationException("ConnectionStrings:ConnectionLocal não encontrada no appsettings.json do projeto web.");

      return new SQLServerContext(cs);
    }
  }
}
