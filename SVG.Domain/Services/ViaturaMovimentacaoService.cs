using SVG.Domain.Entities;
using SVG.Domain.Interfaces;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Enums;

namespace SVG.Domain.Services
{
  public class ViaturaMovimentacaoService
    : ServiceBase<ViaturaMovimentacao>, IViaturaMovimentacaoService
  {
    private readonly IViaturaMovimentacaoRepository _viaturaMovimentacaoRepository;
    private readonly IViaturaRepository _viaturaRepository;

    public ViaturaMovimentacaoService(
      IViaturaMovimentacaoRepository pViaturaMovimentacaoRepository,
      IViaturaRepository pViaturaRepository)
      : base(pViaturaMovimentacaoRepository)
    {
      _viaturaMovimentacaoRepository = pViaturaMovimentacaoRepository;
      _viaturaRepository = pViaturaRepository;
    }

    public IEnumerable<ViaturaMovimentacao> PegarPorViatura(int pViaturaID)
    {
      return _viaturaMovimentacaoRepository
        .PegarPorViatura(pViaturaID);
    }

    public ViaturaMovimentacao PegarUltimaMovimentacao(int pViaturaID)
    {
      return _viaturaMovimentacaoRepository
        .PegarUltimaMovimentacao(pViaturaID);
    }

    public ViaturaMovimentacao? PegarUltimaMovimentacaoViatura(int pViaturaID)
    {
      return _viaturaMovimentacaoRepository.PegarUltimaMovimentacao(pViaturaID);
    }

    private static void ValidarRegistro(DateTime dataHora, int? nivelCombustivel)
    {
      if (dataHora < new DateTime(1753, 1, 1) || dataHora > DateTime.Now)
        throw new Exception("Informe uma data e hora válida, que não seja futura.");
      if (!nivelCombustivel.HasValue || nivelCombustivel < 0 || nivelCombustivel > 100)
        throw new Exception("Informe o nível de combustível entre 0% e 100%.");
    }

    public void RetirarViatura(
      ViaturaMovimentacao pMovimentacao,
      int pOperadorID,
      int pOperadorResponsavelID)
    {
      if (pMovimentacao == null)
        throw new ArgumentNullException(nameof(pMovimentacao));

      if (pOperadorResponsavelID <= 0)
        throw new Exception("Não foi possível identificar o operador logado responsável pelo registro.");

      if (pOperadorID == 0)
        pOperadorID = pOperadorResponsavelID;
      if (pOperadorID < 0)
        throw new Exception("Selecione um operador válido.");

      ValidarRegistro(pMovimentacao.DataHoraRetirada, pMovimentacao.NivelCombustivelRetirada);

      var viatura = _viaturaRepository
        .GetById(pMovimentacao.ViaturaID);

      if (viatura == null)
        throw new Exception("Viatura não encontrada.");

      if (viatura.Situacao == XSituacaoViatura.Manutencao)
        throw new Exception(
          "A viatura está em manutenção e não pode ser retirada.");

      if (viatura.Situacao == XSituacaoViatura.Indisponivel)
        throw new Exception(
          "A viatura está indisponível e não pode ser retirada.");

      var ultimaMovimentacao =
        _viaturaMovimentacaoRepository
          .PegarUltimaMovimentacao(pMovimentacao.ViaturaID);

      if (ultimaMovimentacao != null &&
          pMovimentacao.DataHoraRetirada < (ultimaMovimentacao.DataHoraDevolucao ?? ultimaMovimentacao.DataHoraRetirada))
        throw new Exception("A retirada não pode ser anterior à última movimentação da viatura.");

      /*
       * Caso a última movimentação esteja EmUso,
       * significa que a devolução anterior não foi registrada.
       *
       * O sistema registra automaticamente a devolução,
       * mantendo como responsável o operador da última retirada.
       */
      if (ultimaMovimentacao != null &&
          ultimaMovimentacao.Situacao == XSituacaoViatura.EmUso)
      {


        ultimaMovimentacao.OperadorResponsavelID = pOperadorResponsavelID;
        ultimaMovimentacao.DataHoraDevolucao = pMovimentacao.DataHoraRetirada;
        ultimaMovimentacao.Situacao = XSituacaoViatura.Disponivel;
        

        _viaturaMovimentacaoRepository.Update(ultimaMovimentacao);
      }

      /*
       * Registra o novo fato de retirada.
       */
      pMovimentacao.OperadorID = pOperadorID;
      pMovimentacao.OperadorResponsavelID = pOperadorResponsavelID;
      pMovimentacao.Situacao = XSituacaoViatura.EmUso;
      pMovimentacao.KmInicial = viatura.KmAtual;

      _viaturaMovimentacaoRepository.Add(pMovimentacao);

      /*
       * A situação atual da entidade Viatura funciona como
       * uma informação rápida do estado atual.
       *
       * O histórico verdadeiro está em ViaturaMovimentacao.
       */
      viatura.Situacao = XSituacaoViatura.EmUso;

      _viaturaRepository.Update(viatura);
    }

    public void DevolverViatura(
      int pViaturaID,
      int pOperadorID,
      int pKmFinal,
      bool pAbastecimento,
      int? pKmAbastecimento,
      DateTime pDataHoraDevolucao,
      int pNivelCombustivel,
      int pOperadorResponsavelID)
    {
      if (pOperadorResponsavelID <= 0)
        throw new Exception("Não foi possível identificar o operador logado responsável pelo registro.");

      if (pOperadorID == 0)
        pOperadorID = pOperadorResponsavelID;
      if (pOperadorID < 0)
        throw new Exception("Selecione um operador válido.");

      ValidarRegistro(pDataHoraDevolucao, pNivelCombustivel);

      var viatura = _viaturaRepository
        .GetById(pViaturaID);

      if (viatura == null)
        throw new Exception("Viatura não encontrada.");

      var ultimaMovimentacao =
        _viaturaMovimentacaoRepository
          .PegarUltimaMovimentacao(pViaturaID);

      if (ultimaMovimentacao == null)
        throw new Exception(
          "Não existe movimentação registrada para esta viatura.");

      if (ultimaMovimentacao.Situacao != XSituacaoViatura.EmUso)
        throw new Exception(
          "A viatura não possui uma retirada em aberto.");

      if (pDataHoraDevolucao < ultimaMovimentacao.DataHoraRetirada)
        throw new Exception("A devolução não pode ser anterior à retirada.");

      ultimaMovimentacao.KmFinal = pKmFinal;
      ultimaMovimentacao.DataHoraDevolucao = pDataHoraDevolucao;
      ultimaMovimentacao.NivelCombustivelDevolucao = pNivelCombustivel;
      ultimaMovimentacao.Situacao = XSituacaoViatura.Disponivel;
      ultimaMovimentacao.OperadorID = pOperadorID;
      ultimaMovimentacao.OperadorResponsavelID = pOperadorResponsavelID;
      ultimaMovimentacao.Abastecimento = pAbastecimento;
      ultimaMovimentacao.KmAbastecimento = pKmAbastecimento;

      _viaturaMovimentacaoRepository.Update(ultimaMovimentacao);

      viatura.Situacao = XSituacaoViatura.Disponivel;
      viatura.KmAtual = ultimaMovimentacao.KmFinal.Value;

      if (pAbastecimento && pKmAbastecimento.HasValue)
        viatura.KmUltimoAbastecimento = pKmAbastecimento;

      _viaturaRepository.Update(viatura);
    }
  }
}