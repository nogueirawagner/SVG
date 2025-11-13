using SVG.App.Interface;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace SVG.App.Services
{
  public class OperadorAppService : AppServiceBase<Operador>, IOperadorAppService
  {
    private readonly IOperadorService _OperadorService;

    public OperadorAppService(IOperadorService OperadorService)
        : base(OperadorService)
    {
      _OperadorService = OperadorService;
    }

    //public void AtualizarNotaCFP(int pOperadorId, double pNota)
    //{
    //  _OperadorService.AtualizarNotaCFP(pOperadorId, pNota);
    //}

    //public IEnumerable<OperadorViewModel> PesquisarOperadorsPorPalavras(string pTermo, string pConcorrencia, string pCargo )
    //{
    // return _OperadorService.PesquisarOperadorsPorPalavras(pTermo, pConcorrencia, pCargo);
    //}

    //public IEnumerable<OperadorViewModel> PegarOperadorsPorCargoConcorrencia(string pCargo, string pConcorrencia)
    //{
    //  return _OperadorService.PegarOperadorsPorCargoConcorrencia(pCargo, pConcorrencia);
    //}

    //public string PegarMediaCalculada()
    //{
    //  return _OperadorService.PegarMediaCalculada();
    //}
  }
}
