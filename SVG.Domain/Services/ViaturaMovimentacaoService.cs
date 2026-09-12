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

      var dataHoraMovimentacao = DateTime.Now;

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
        var devolucaoAutomatica = new ViaturaMovimentacao
        {
          ViaturaID = pMovimentacao.ViaturaID,

          // Importantíssimo:
          // permanece o operador responsável pela retirada anterior.
          OperadorID = ultimaMovimentacao.OperadorID,

          Finalidade = ultimaMovimentacao.Finalidade,

          DataHora = dataHoraMovimentacao,

          Situacao = XSituacaoViatura.Disponivel
        };

        _viaturaMovimentacaoRepository.Add(devolucaoAutomatica);
      }

      /*
       * Registra o novo fato de retirada.
       */
      pMovimentacao.OperadorID = pOperadorID;
      pMovimentacao.DataHora = dataHoraMovimentacao;
      pMovimentacao.Situacao = XSituacaoViatura.EmUso;

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
      int pOperadorID)
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

      var devolucao = new ViaturaMovimentacao
      {
        ViaturaID = pViaturaID,
        OperadorID = pOperadorID,
        Finalidade = ultimaMovimentacao.Finalidade,
        DataHora = DateTime.Now,
        Situacao = XSituacaoViatura.Disponivel
      };

      _viaturaMovimentacaoRepository.Add(devolucao);

      viatura.Situacao = XSituacaoViatura.Disponivel;

      _viaturaRepository.Update(viatura);
    }
  }
}