using SVG.App.Interface;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.TiposOperador;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

    public XOperadorSelecionado ObterPorMatriculaNormalizada(string matriculaNormalizada)
    {
      if (string.IsNullOrWhiteSpace(matriculaNormalizada))
        return null;

      // Garante normalização (defesa extra)
      var normalizada = Regex.Replace(matriculaNormalizada, @"\D", "");

      return _operadorService.ObterPorMatriculaNormalizada(normalizada);
    }


    public IEnumerable<XDetalhamentoOperadorOperacao> PegarDetalhamentoOperador(int pOperadorId)
    {
      return _operadorService.PegarDetalhamentoOperador(pOperadorId);
    }

    public IEnumerable<int> PegarOperadoresOperacao(int pOperacaoId)
    {
      return _operadorService.PegarOperadoresOperacao(pOperacaoId);
    }

    public IEnumerable<XResumoOperadorOperacao> PegarResumoOperador()
    {
      return _operadorService.PegarResumoOperador();  
    }
  }
}
