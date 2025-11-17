using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;

namespace SVG.Domain.Services
{
  public class OperacaoService : ServiceBase<Operacao>, IOperacaoService
  {
    private readonly IOperacaoRepository _operacaoRepository;

    public OperacaoService(IOperacaoRepository operacaoRepository)
      : base(operacaoRepository)
    {
      _operacaoRepository = operacaoRepository;
    }
  }
}
