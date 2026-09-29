using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;

namespace SVG.Domain.Services
{
  public class AfastamentoOperadorService
    : ServiceBase<AfastamentoOperador>, IAfastamentoOperadorService
  {
    private readonly IAfastamentoOperadorRepository _afastamentoOperadorRepository;

    public AfastamentoOperadorService(
      IAfastamentoOperadorRepository afastamentoOperadorRepository)
      : base(afastamentoOperadorRepository)
    {
      _afastamentoOperadorRepository = afastamentoOperadorRepository;
    }

    public IEnumerable<AfastamentoOperador> PegarAfastamentos()
    {
      return _afastamentoOperadorRepository.PegarAfastamentos();
    }

    public IEnumerable<AfastamentoOperador> PegarPorPeriodo(
      DateTime pDataInicio,
      DateTime pDataFim)
    {
      return _afastamentoOperadorRepository
        .PegarPorPeriodo(pDataInicio, pDataFim);
    }

    public IEnumerable<AfastamentoOperador> PegarPorOperadorEData(
      int pOperadorID,
      DateTime pData)
    {
      return _afastamentoOperadorRepository
        .PegarPorOperadorEData(pOperadorID, pData);
    }

    public bool ExisteAfastamentoNoPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime pDataFim,
      int? pAfastamentoOperadorID = null)
    {
      return _afastamentoOperadorRepository.ExisteAfastamentoNoPeriodo(
        pOperadorID,
        pDataInicio,
        pDataFim,
        pAfastamentoOperadorID);
    }

    public IEnumerable<int> PegarAnosComAfastamentos()
    {
      return _afastamentoOperadorRepository
        .PegarAnosComAfastamentos();
    }
  }
}