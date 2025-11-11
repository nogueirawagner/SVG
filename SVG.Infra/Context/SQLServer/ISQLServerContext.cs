using SVG.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SVG.Infra.Context.SQLServer
{
  public interface ISQLServerContext
  {
    DbEntityEntry Entry(object entity);
    int SaveChanges();
    DbSet<T> Set<T>() where T : class;
    DbSet<Operador> Operador { get; set; }
  }
}
