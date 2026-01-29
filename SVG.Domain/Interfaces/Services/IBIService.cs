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
    Task<IEnumerable<XAdesaoSvg>> ObterMensalAsync();
    Task<IEnumerable<XAdesaoSvg>> ObterBimestralAsync();
    Task<IEnumerable<XAdesaoSvg>> ObterTrimestralAsync();
    Task<IEnumerable<XAdesaoSvg>> ObterSemestralAsync();
    Task<IEnumerable<XOperacaoBi>> ObterOperacoesPeriodo(string periodo);
    Task<IEnumerable<XParticipacaoOperador>> ObterParticipacaoOperadorPeriodo(string periodo);
  }
}
