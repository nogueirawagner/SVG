using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.BI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Interfaces.Repositories
{
  public interface IBIRepository : IRepositoryBase<Operacao>
  {
    Task<XBiDashboard> ObterDashboardAsync(XPeriodicidade periodicidade);

    Task<XBiResultado> ObterAdesaoSvgAsync(XPeriodicidade periodicidade);

    Task<XBiResultado> ObterOperacoesAsync(XPeriodicidade periodicidade);

    Task<XBiResultado> ObterParticipacaoOperadorAsync(XPeriodicidade periodicidade);

    Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(XPeriodicidade periodicidade);
    
    Task<IEnumerable<int>> ObterAnosAsync();

    Task<XBiDataRange> ObterRangeDatasAsync();

    Task<IEnumerable<XBiOperadorFiltro>> ObterOperadoresAsync();
  }
}
