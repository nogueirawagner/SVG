using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.Operador;
using System.Collections.Generic;

namespace SVG.App.Interface
{
  public interface IOperadorAppService : IAppServiceBase<Operador>
  {
    public IEnumerable<ResumoOperadorOperacao> PegarResumoOperador();
  }
}
