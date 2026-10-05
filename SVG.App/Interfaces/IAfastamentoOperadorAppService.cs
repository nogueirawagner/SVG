using SVG.Domain.Entities;

namespace SVG.App.Interface
{
  public interface IAfastamentoOperadorAppService
    : IAppServiceBase<AfastamentoOperador>
  {
    IEnumerable<AfastamentoOperador> PegarAfastamentos();

    IEnumerable<AfastamentoOperador> PegarPorPeriodo(
      DateTime pDataInicio,
      DateTime pDataFim);

    bool ExisteAfastamentoNoPeriodo(
      int pOperadorID,
      DateTime pDataInicio,
      DateTime pDataFim,
      int? pAfastamentoOperadorID = null);

    IEnumerable<AfastamentoOperador> PegarPorOperadorEData(
      int pOperadorID,
      DateTime pData);

    IEnumerable<int> PegarAnosComAfastamentos();

    IEnumerable<AfastamentoOperador> ObterPorSecaoEPeriodo(
      int pSecaoId,
      DateTime pInicio,
      DateTime pFim);
  }
}