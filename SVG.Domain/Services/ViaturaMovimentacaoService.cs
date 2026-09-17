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

    public void RetirarViatura(
      ViaturaMovimentacao pMovimentacao,
      int pOperadorID)
    {
      if (pMovimentacao == null)
        throw new ArgumentNullException(nameof(pMovimentacao));

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


        ultimaMovimentacao.DataHoraDevolucao = DateTime.Now;
        

        _viaturaMovimentacaoRepository.Update(ultimaMovimentacao);
      }

      /*
       * Registra o novo fato de retirada.
       */
      pMovimentacao.OperadorID = pOperadorID;
      pMovimentacao.DataHoraRetirada = DateTime.Now;
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
      int? pKmAbastecimento)
    {
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

      ultimaMovimentacao.KmFinal = pKmFinal;
      ultimaMovimentacao.DataHoraDevolucao = DateTime.Now;
      ultimaMovimentacao.Situacao = XSituacaoViatura.Disponivel;
      ultimaMovimentacao.OperadorID = pOperadorID;
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