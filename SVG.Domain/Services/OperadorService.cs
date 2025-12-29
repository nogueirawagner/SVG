using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.TiposOperador;

namespace SVG.Domain.Services
{
  public class OperadorService : ServiceBase<Operador>, IOperadorService
  {
    private readonly IOperadorRepository _operadorRepository;

    public OperadorService(IOperadorRepository operadorRepository)
   : base(operadorRepository)
    {
      _operadorRepository = operadorRepository;
    }

    public IEnumerable<XDetalhamentoOperadorOperacao> PegarDetalhamentoOperador(int pOperadorId)
    {
      return _operadorRepository.PegarDetalhamentoOperador(pOperadorId);
    }

    public IEnumerable<XResumoOperadorOperacao> PegarResumoOperador()
    {
      return _operadorRepository.PegarResumoOperador();
    }

    public IEnumerable<int> PegarOperadoresOperacao(int pOperacaoId)
    {
      return _operadorRepository.PegarOperadoresOperacao(pOperacaoId);
    }
  }
}
