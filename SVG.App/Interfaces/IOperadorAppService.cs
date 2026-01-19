using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperador;
using System.Collections.Generic;

namespace SVG.App.Interface
{
  public interface IOperadorAppService : IAppServiceBase<Operador>
  {
    public IEnumerable<XResumoOperadorOperacao> PegarResumoOperador();
    IEnumerable<XDetalhamentoOperadorOperacao> PegarDetalhamentoOperador(int pOperadorId);
    IEnumerable<int> PegarOperadoresOperacao(int pOperacaoId);
    XOperadorSelecionado ObterPorMatriculaNormalizada(string matriculaNormalizada);
  }
}
