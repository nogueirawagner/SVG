using Microsoft.EntityFrameworkCore;
using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperacao;
using SVG.Domain.TiposEstruturados.TiposOperador;

namespace SVG.Infra.Context.SQLServer
{
  public class SQLServerContext : DbContext, ISqlServerContext
  {
    public SQLServerContext(DbContextOptions<SQLServerContext> options)
        : base(options)
    {
    }

    #region DbSets
    public DbSet<Operador> Operador { get; set; }
    public DbSet<Operacao> Operacao { get; set; }
    public DbSet<OperadorOperacao> OperadorOperacao { get; set; }
    public DbSet<Sessao> Sessao { get; set; }
    public DbSet<Viatura> Viatura { get; set; }
    public DbSet<ViaturaOperacao> ViaturaOperacao { get; set; }
    public DbSet<TipoOperacao> TipoOperacoes { get; set; }
    public DbSet<CandidatoSVGOperacao> CandidatoSVGOperacao { get; set; }
    public DbSet<CalendarioPlantao> CalendarioPlantao { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      // 🔹 Remove pluralização (EF Core NÃO pluraliza por padrão)
      // (não precisa fazer nada aqui)

      // 🔹 Remove cascade delete automático
      foreach (var fk in modelBuilder.Model.GetEntityTypes()
                   .SelectMany(e => e.GetForeignKeys()))
      {
        fk.DeleteBehavior = DeleteBehavior.Restrict;
      }

      // 🔹 Convenção para chave primária: {EntityName}Id ou {EntityName}ID
      foreach (var entity in modelBuilder.Model.GetEntityTypes())
      {
        var pkProperty = entity.ClrType.GetProperties()
            .FirstOrDefault(p =>
                p.Name == $"{entity.ClrType.Name}Id" ||
                p.Name == $"{entity.ClrType.Name}ID");

        if (pkProperty != null)
        {
          modelBuilder.Entity(entity.ClrType)
              .HasKey(pkProperty.Name);
        }
      }
    }
  }
}
