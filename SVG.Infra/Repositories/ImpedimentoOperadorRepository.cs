using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using System.Data.Entity;

namespace SVG.Infra.Repositories
{
  public class ImpedimentoOperadorRepository
    : RepositoryBase<ImpedimentoOperador>, IImpedimentoOperadorRepository
  {
    private readonly SQLServerContext _db;

    public ImpedimentoOperadorRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }

    public IEnumerable<ImpedimentoOperador> PegarImpedimentos()
    {
      return _db.ImpedimentoOperador
        .Include(x => x.Operador)
        .OrderBy(x => x.DataInicio)
        .ToList();
    }

    public IEnumerable<ImpedimentoOperador> PegarPorPeriodo(
      DateTime pDataInicio,
      DateTime pDataFim)
    {
      return _db.ImpedimentoOperador
        .Include(x => x.Operador)
        .Where(x =>
          x.DataInicio <= pDataFim &&
          (!x.DataFim.HasValue ||
           x.DataFim.Value >= pDataInicio))
        .OrderBy(x => x.DataInicio)
        .ToList();
    }

    public IEnumerable<ImpedimentoOperador> PegarPorOperadorEData(
      int pOperadorID,
      DateTime pData)
    {
      return _db.ImpedimentoOperador
        .Include(x => x.Operador)
        .Where(x =>
          x.OperadorID == pOperadorID &&
          x.DataInicio <= pData &&
          (!x.DataFim.HasValue ||
           x.DataFim.Value >= pData))
        .OrderBy(x => x.DataInicio)
        .ToList();
    }

    public bool ExisteImpedimentoNoPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime? pDataFim,
      int? pImpedimentoOperadorID = null)
    {
      var query = _db.ImpedimentoOperador
        .Where(x => x.OperadorID == pOperadorID);

      if (pDataFim.HasValue)
      {
        var dataFim = pDataFim.Value;

        query = query.Where(x =>
          x.DataInicio <= dataFim &&
          (!x.DataFim.HasValue ||
           x.DataFim.Value >= pDataInicio));
      }
      else
      {
        // Novo impedimento sem término.
        // Conflita com qualquer impedimento que ainda alcance
        // a data inicial informada ou comece depois dela.
        query = query.Where(x =>
          !x.DataFim.HasValue ||
          x.DataFim.Value >= pDataInicio);
      }

      if (pImpedimentoOperadorID.HasValue)
      {
        query = query.Where(
          x => x.ID != pImpedimentoOperadorID.Value);
      }

      return query.Any();
    }

    public IEnumerable<ImpedimentoOperador> PegarPorOperadorEPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime pDataFim)
    {
      return _db.ImpedimentoOperador
        .Include(x => x.Operador)
        .Where(x =>
          x.OperadorID == pOperadorID &&
          x.DataInicio <= pDataFim &&
          (!x.DataFim.HasValue ||
           x.DataFim.Value >= pDataInicio))
        .OrderBy(x => x.DataInicio)
        .ToList();
    }

    public IEnumerable<int> PegarAnosComImpedimentos()
    {
      var anoAtual = DateTime.Now.Year;

      var periodos = _db.ImpedimentoOperador
        .Select(x => new
        {
          x.DataInicio,
          x.DataFim
        })
        .ToList();

      return periodos
        .SelectMany(x =>
        {
          /*
           * Impedimento sem DataFim continua vigente.
           * Nesse caso, consideramos até o ano atual
           * para composição do filtro de anos.
           */
          var anoFim = x.DataFim.HasValue
            ? x.DataFim.Value.Year
            : Math.Max(
                anoAtual,
                x.DataInicio.Year);

          return Enumerable.Range(
            x.DataInicio.Year,
            anoFim - x.DataInicio.Year + 1);
        })
        .Distinct()
        .OrderByDescending(x => x)
        .ToList();
    }
  }
}