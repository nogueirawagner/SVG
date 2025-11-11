using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;

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
  }
}
