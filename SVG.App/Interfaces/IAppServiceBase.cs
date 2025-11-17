using System.Collections.Generic;

namespace SVG.App.Interface
{
  public interface IAppServiceBase<TEntity> where TEntity : class
  {
    void SaveOrUpdate(TEntity obj);

    void AddRange(IEnumerable<TEntity> objList);

    void Add(TEntity obj);

    TEntity GetById(int id);

    void Update(TEntity obj);

    IEnumerable<TEntity> GetAll();

    void Remove(TEntity obj);

    void Dispose();
  }
}
