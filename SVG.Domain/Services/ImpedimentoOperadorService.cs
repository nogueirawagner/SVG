using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;

namespace SVG.Domain.Services
{
  public class ImpedimentoOperadorService
    : ServiceBase<ImpedimentoOperador>, IImpedimentoOperadorService
  {
    private readonly IImpedimentoOperadorRepository _impedimentoOperadorRepository;

    public ImpedimentoOperadorService(
      IImpedimentoOperadorRepository impedimentoOperadorRepository)
      : base(impedimentoOperadorRepository)
    {
      _impedimentoOperadorRepository = impedimentoOperadorRepository;
    }

    public IEnumerable<ImpedimentoOperador> PegarImpedimentos()
    {
      return _impedimentoOperadorRepository.PegarImpedimentos();
    }

    public IEnumerable<ImpedimentoOperador> PegarPorPeriodo(
      DateTime pDataInicio,
      DateTime pDataFim)
    {
      return _impedimentoOperadorRepository
        .PegarPorPeriodo(pDataInicio, pDataFim);
    }

    public IEnumerable<ImpedimentoOperador> PegarPorOperadorEData(
      int pOperadorID,
      DateTime pData)
    {
      return _impedimentoOperadorRepository
        .PegarPorOperadorEData(pOperadorID, pData);
    }

    public bool ExisteImpedimentoNoPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime? pDataFim,
      int? pImpedimentoOperadorID = null)
    {
      return _impedimentoOperadorRepository.ExisteImpedimentoNoPeriodo(
        pOperadorID,
        pDataInicio,
        pDataFim,
        pImpedimentoOperadorID);
    }
  }
}