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

    public Task<IEnumerable<XAdesaoSvg>> ObterBimestralAsync()
    {
      return _biRepository.ObterBimestralAsync();
    }

    public Task<IEnumerable<XAdesaoSvg>> ObterMensalAsync()
    {
      return _biRepository.ObterMensalAsync();
    }

    public Task<IEnumerable<XAdesaoSvg>> ObterSemestralAsync()
    {
      return _biRepository.ObterMensalAsync();
    }

    public Task<IEnumerable<XAdesaoSvg>> ObterTrimestralAsync()
    {
      return _biRepository.ObterMensalAsync();
    }

    public Task<IEnumerable<XOperacaoBi>> ObterOperacoesPeriodo(string periodo)
    {
      return _biRepository.ObterOperacoesPeriodo(periodo);
    }

    public Task<IEnumerable<XParticipacaoOperador>> ObterParticipacaoOperadorPeriodo(string periodo)
    {
      return _biRepository.ObterParticipacaoOperadorPeriodo(periodo);
    }
  }
}
