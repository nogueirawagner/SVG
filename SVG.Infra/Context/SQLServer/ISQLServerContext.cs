using SVG.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SVG.Infra.Context.SQLServer
{
  public interface ISqlServerContext
  {
    EntityEntry Entry(object entity);
    int SaveChanges();
    DbSet<T> Set<T>() where T : class;
  }
}
