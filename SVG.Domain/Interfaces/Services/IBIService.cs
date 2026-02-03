using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.BI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Interfaces.Services
{
  public interface IBIService : IServiceBase<Operacao>
  {
    Task<XBiDashboard> ObterDashboardAsync(
       string periodo, int? ano, int? secaoId, int? operadorId);

    Task<IEnumerable<XBiSerie>> ObterAdesaoSvgAsync(
        string periodo, int? ano, int? secaoId, int? operadorId);

    Task<IEnumerable<XBiSerie>> ObterOperacoesAsync(
        string periodo, int? ano, int? secaoId, int? operadorId);

    Task<IEnumerable<XBiSerie>> ObterParticipacaoOperadorAsync(
        string periodo, int? ano, int? secaoId, int? operadorId);

    Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(
        string periodo, int? ano, int? secaoId);
  }
}
