using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Interfaces.Repositories
{
  public interface IOperadorRepository : IRepositoryBase<Operador>
  {
    public IEnumerable<ResumoOperadorOperacao> PegarResumoOperador();
    IEnumerable<DetalhamentoOperadorOperacao> PegarDetalhamentoOperador(int pOperadorId);
    IEnumerable<int> PegarOperadoresOperacao(int pOperacaoId);
  }
}
