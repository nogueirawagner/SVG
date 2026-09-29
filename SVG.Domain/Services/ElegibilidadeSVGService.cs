using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados;
using SVG.Domain.TiposEstruturados.TiposOperador;
using SVG.Utilities.ExtensionsMethods;

namespace SVG.Domain.Services
{
  public class ElegibilidadeSVGService : IElegibilidadeSVGService
  {
    private readonly IAfastamentoOperadorRepository _afastamentoOperadorRepository;
    private readonly IImpedimentoOperadorRepository _impedimentoOperadorRepository;

    public ElegibilidadeSVGService(
      IAfastamentoOperadorRepository afastamentoOperadorRepository,
      IImpedimentoOperadorRepository impedimentoOperadorRepository)
    {
      _afastamentoOperadorRepository = afastamentoOperadorRepository;
      _impedimentoOperadorRepository = impedimentoOperadorRepository;
    }

    public XResultadoElegibilidadeSVG VerificarElegibilidade(
      int pOperadorID,
      DateTime pDataReferencia)
    {
      var resultado = new XResultadoElegibilidadeSVG();

      var dataReferencia = pDataReferencia.Date;

      VerificarAfastamentos(
        pOperadorID,
        dataReferencia,
        resultado);

      VerificarImpedimentos(
        pOperadorID,
        dataReferencia,
        resultado);

      return resultado;
    }

    private void VerificarAfastamentos(
      int pOperadorID,
      DateTime pDataReferencia,
      XResultadoElegibilidadeSVG pResultado)
    {
      var afastamentos =
        _afastamentoOperadorRepository.PegarPorOperadorEData(
          pOperadorID,
          pDataReferencia);

      foreach (var afastamento in afastamentos)
      {
        if (!AfastamentoImpedeSVG(afastamento.TipoAfastamento))
          continue;

        pResultado.Motivos.Add(afastamento.TipoAfastamento.GetDescription());

        AtualizarDataFinalImpedimento(
          pResultado,
          afastamento.DataFim.Date);
      }
    }

    private void VerificarImpedimentos(
      int pOperadorID,
      DateTime pDataReferencia,
      XResultadoElegibilidadeSVG pResultado)
    {
      /*
       * Para restrição médica precisamos considerar também
       * os 15 dias posteriores ao término.
       *
       * Por isso buscamos impedimentos desde 15 dias antes
       * da data de referência.
       */
      var dataConsultaInicio = pDataReferencia.AddDays(-15);

      var impedimentos = _impedimentoOperadorRepository.PegarPorOperadorEPeriodo(
        pOperadorID,
        dataConsultaInicio,
        pDataReferencia);

      impedimentos = impedimentos
        .Where(x => x.OperadorID == pOperadorID);

      foreach (var impedimento in impedimentos)
      {
        var dataFimEfetiva =
          ObterDataFimEfetivaImpedimento(impedimento);

        var vigente =
          impedimento.DataInicio.Date <= pDataReferencia &&
          (!dataFimEfetiva.HasValue ||
           dataFimEfetiva.Value.Date >= pDataReferencia);

        if (!vigente)
          continue;

        pResultado.Motivos.Add(impedimento.TipoImpedimento.GetDescription());

        AtualizarDataFinalImpedimento(
          pResultado,
          dataFimEfetiva);
      }
    }

    private bool AfastamentoImpedeSVG(
      XTipoAfastamento pTipoAfastamento)
    {
      switch (pTipoAfastamento)
      {
        case XTipoAfastamento.Ferias:
        case XTipoAfastamento.AbonoPontoAnual:
        case XTipoAfastamento.AbonoAniversario:
          return false;

        default:
          return true;
      }
    }

    private DateTime? ObterDataFimEfetivaImpedimento(
      ImpedimentoOperador pImpedimento)
    {
      if (!pImpedimento.DataFim.HasValue)
        return null;

      var dataFim = pImpedimento.DataFim.Value.Date;

      if (pImpedimento.TipoImpedimento ==
          XTipoImpedimentoOperador.RestricaoMedicaOperacional)
      {
        return dataFim.AddDays(15);
      }

      return dataFim;
    }

    private void AtualizarDataFinalImpedimento(
      XResultadoElegibilidadeSVG pResultado,
      DateTime? pDataFim)
    {
      /*
       * Null significa que existe impedimento
       * por prazo indeterminado.
       */
      if (!pDataFim.HasValue)
      {
        pResultado.ImpedidoAte = null;
        return;
      }

      /*
       * Se já existe algum motivo por prazo indeterminado,
       * permanece null.
       */
      if (pResultado.Motivos.Count > 1 &&
          !pResultado.ImpedidoAte.HasValue)
      {
        return;
      }

      if (!pResultado.ImpedidoAte.HasValue ||
          pDataFim.Value > pResultado.ImpedidoAte.Value)
      {
        pResultado.ImpedidoAte = pDataFim.Value;
      }
    }
  }
}