using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;

namespace SVG.Domain.Services
{
  public class OperadorOperacaoService : ServiceBase<OperadorOperacao>, IOperadorOperacaoService
  {
    private readonly IOperadorOperacaoRepository _operadorOperacaoRepository;

    public OperadorOperacaoService(IOperadorOperacaoRepository operadorOperacaoRepository)
      : base(operadorOperacaoRepository)
    {
      _operadorOperacaoRepository = operadorOperacaoRepository;
    }
  }
}
