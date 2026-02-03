using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.BI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Services
{
  public class BIService : ServiceBase<Operacao>, IBIService
  {
    private readonly IBIRepository _biRepository;

    public BIService(IBIRepository biRepository)
      : base(biRepository)
    {
      _biRepository = biRepository;
    }

    public Task<IEnumerable<XBiSerie>> ObterAdesaoSvgAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biRepository.ObterAdesaoSvgAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<XBiDashboard> ObterDashboardAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biRepository.ObterDashboardAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<IEnumerable<XBiSerie>> ObterOperacoesAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biRepository.ObterOperacoesAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<IEnumerable<XBiSerie>> ObterParticipacaoOperadorAsync(string periodo, int? ano, int? secaoId, int? operadorId)
    {
      return _biRepository.ObterOperacoesAsync(periodo, ano, secaoId, operadorId);
    }

    public Task<IEnumerable<XTopOperador>> ObterTopOperadoresAsync(string periodo, int? ano, int? secaoId)
    {
      return _biRepository.ObterTopOperadoresAsync(periodo, ano, secaoId);  
    }
  }
}
