using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Interfaces.Services
{
  public interface IOperadorService : IServiceBase<Operador>
  {
    public IEnumerable<XResumoOperadorOperacao> PegarResumoOperador();
    IEnumerable<XDetalhamentoOperadorOperacao> PegarDetalhamentoOperador(int pOperadorId);
    IEnumerable<int> PegarOperadoresOperacao(int pOperacaoId);
    XOperadorSelecionado ObterPorMatriculaNormalizada(string matriculaNormalizada);
  }
}
