using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using System.Data.Entity;

namespace SVG.Infra.Repositories
{
  public class AfastamentoOperadorRepository
    : RepositoryBase<AfastamentoOperador>, IAfastamentoOperadorRepository
  {
    private readonly SQLServerContext _db;

    public AfastamentoOperadorRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }
   
    public IEnumerable<AfastamentoOperador> PegarAfastamentos()
    {
      return _db.AfastamentoOperador
        .Include(x => x.Operador)
        .Include(x => x.Operador.Sessao)
        .OrderBy(x => x.DataInicio)
        .ToList();
    }

    public IEnumerable<AfastamentoOperador> PegarPorPeriodo(
      DateTime pDataInicio,
      DateTime pDataFim)
    {
      return _db.AfastamentoOperador
        .Include(x => x.Operador)
        .Where(x =>
          x.DataInicio <= pDataFim &&
          x.DataFim >= pDataInicio)
        .OrderBy(x => x.DataInicio)
        .ToList();
    }

    public IEnumerable<AfastamentoOperador> PegarPorOperadorEData(
      int pOperadorID,
      DateTime pData)
    {
      return _db.AfastamentoOperador
        .Include(x => x.Operador)
        .Where(x =>
          x.OperadorID == pOperadorID &&
          x.DataInicio <= pData &&
          x.DataFim >= pData)
        .OrderBy(x => x.DataInicio)
        .ToList();
    }

    public bool ExisteAfastamentoNoPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime pDataFim,
      int? pAfastamentoOperadorID = null)
    {
      var query = _db.AfastamentoOperador
        .Where(x =>
          x.OperadorID == pOperadorID &&
          x.DataInicio <= pDataFim &&
          x.DataFim >= pDataInicio);

      if (pAfastamentoOperadorID.HasValue)
      {
        query = query.Where(
          x => x.ID != pAfastamentoOperadorID.Value);
      }

      return query.Any();
    }

    public IEnumerable<int> PegarAnosComAfastamentos()
    {
      var periodos = _db.AfastamentoOperador
        .Select(x => new
        {
          x.DataInicio,
          x.DataFim
        })
        .ToList();

      return periodos
        .SelectMany(x =>
          Enumerable.Range(
            x.DataInicio.Year,
            x.DataFim.Year - x.DataInicio.Year + 1))
        .Distinct()
        .OrderByDescending(x => x)
        .ToList();
    }
  }
}