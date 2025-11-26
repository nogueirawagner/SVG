using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Operador;

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

    public IEnumerable<ResumoOperadorOperacao> PegarResumoOperador()
    {
      return _operadorRepository.PegarResumoOperador();
    }
  }
}
