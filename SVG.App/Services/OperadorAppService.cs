using SVG.App.Interface;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.TiposOperador;
using System.Collections.Generic;

namespace SVG.App.Services
{
  public class OperadorAppService : AppServiceBase<Operador>, IOperadorAppService
  {
    private readonly IOperadorService _operadorService;

    public OperadorAppService(IOperadorService operadorService)
        : base(operadorService)
    {
      _operadorService = operadorService;
    }

    public IEnumerable<DetalhamentoOperadorOperacao> PegarDetalhamentoOperador(int pOperadorId)
    {
      return _operadorService.PegarDetalhamentoOperador(pOperadorId);
    }

    public IEnumerable<ResumoOperadorOperacao> PegarResumoOperador()
    {
      return _operadorService.PegarResumoOperador();  
    }
  }
}
