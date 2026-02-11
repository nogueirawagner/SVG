using SVG.App.Interface;
using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.BI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.App.Interfaces
{
  public interface IBIAppService : IAppServiceBase<Operacao>
  {

    Task<XBiDashboard> ObterDashboardAsync(XPeriodicidade periodicidade);

    Task<IEnumerable<XBiSerie>> ObterAdesaoSvgAsync(XPeriodicidade periodicidade);

    Task<IEnumerable<XBiSerie>> ObterOperacoesAsync(XPeriodicidade periodicidade);

    Task<IEnumerable<XBiSerie>> ObterParticipacaoOperadorAsync(XPeriodicidade periodicidade);

    Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(XPeriodicidade periodicidade);

    Task<XBiFiltros> ObterFiltrosAsync();
  }
}
