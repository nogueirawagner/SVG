using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using System.Data.Entity;

namespace SVG.Infra.Repositories
{
  public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
  {
    //aqui rabalha com objetos genericos
    protected SQLServerContext _db;

    public RepositoryBase(SQLServerContext sqlContext)
    {
      _db = sqlContext;
    }

    public void Add(TEntity obj)
    {
      _db.Set<TEntity>().Add(obj);
      _db.SaveChanges();
    }

    public void SaveOrUpdate(TEntity obj)
    {
      _db.Set<TEntity>().Add(obj);
      _db.SaveChanges();
    }

    public TEntity GetById(int id)
    {
      //retornando um objeto
      return _db.Set<TEntity>().Find(id);
    }

    public IEnumerable<TEntity> GetAll()
    {
      //retornando varios objetos
      return _db.Set<TEntity>().ToList();
    }

    public void Update(TEntity obj)
    {
      //realiza o update seta o objeto como modificado
      _db.Entry(obj).State = EntityState.Modified;
      _db.SaveChanges();
    }

    public void Remove(TEntity obj)
    {
      //remove o objeto
      _db.Set<TEntity>().Remove(obj);
      _db.SaveChanges();
    }

    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }
  }
}
