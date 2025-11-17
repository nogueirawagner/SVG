using System.Collections.Generic;

namespace SVG.Domain.Interfaces.Repositories
{
  public interface IRepositoryBase<TEntity> where TEntity : class
  {
    void SaveOrUpdate(TEntity obj);

    void AddRange(IEnumerable<TEntity> objList);

    //adiciona no banco de dados o obj
    void Add(TEntity obj);

    //seleciona por ID
    TEntity GetById(int id);

    //retorna um Ienumerable
    IEnumerable<TEntity> GetAll();

    //realiza update recebendo objeto
    void Update(TEntity obj);

    //realiza delete recebendo objeto
    void Remove(TEntity obj);

    //dispose força a implementar 
    void Dispose();
  }
}
