using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SVG.App.Interface;
using SVG.App.Services;
using SVG.Domain.Entities;
using SVG.WebApp.Models;
using System.Security.Claims;

namespace SVG.WebApp.Controllers
{
  [Authorize]
  public class ViaturaController : Controller
  {
    private readonly IViaturaAppService _viaturaAppService;
    private readonly IViaturaMovimentacaoAppService _viaturaMovimentacaoAppService;
    private readonly IOperadorAppService _operadorAppService;
    private readonly ISessaoAppService _sessaoAppService;

    public ViaturaController(
      IViaturaAppService pViaturaAppService,
      IViaturaMovimentacaoAppService pViaturaMovimentacaoAppService,
      IOperadorAppService pOperadorAppService,
      ISessaoAppService sessaoAppService)
    {
      _viaturaAppService = pViaturaAppService;
      _viaturaMovimentacaoAppService = pViaturaMovimentacaoAppService;
      _operadorAppService = pOperadorAppService;
      _sessaoAppService = sessaoAppService;
    }

    // GET: Viatura/Listar
    [HttpGet]
    public IActionResult Listar()
    {
      var viaturas = _viaturaAppService.PegarViaturas();
      return View(viaturas);
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult Editar(int pViaturaID)
    {
      var viatura = _viaturaAppService.GetById(pViaturaID);
      if (viatura == null)
        return NotFound();

      var model = new ViaturaEdicaoViewModel
      {
        ViaturaID = viatura.ID,
        Prefixo = viatura.Prefixo,
        Placa = viatura.Placa,
        PlacaOficial = viatura.PlacaOficial,
        Marca = viatura.Marca,
        Modelo = viatura.Modelo,
        Ano = viatura.Ano,
        Chassi = viatura.Chassi,
        SessaoID = viatura.SessaoID,
        OperadorResponsavelID = viatura.OperadorResponsavelID,
        TipoCaracterizacao = viatura.TipoCaracterizacao,
        KmAtual = viatura.KmAtual,
        KmUltimoAbastecimento = viatura.KmUltimoAbastecimento,
        KmProximaRevisao = viatura.KmProximaRevisao,
      };
      PopularCombosEdicao();
      return View(model);
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Editar(ViaturaEdicaoViewModel pModel)
    {
      var viatura = _viaturaAppService.GetById(pModel.ViaturaID);
      if (viatura == null)
        return NotFound();

      if (_sessaoAppService.GetById(pModel.SessaoID) == null)
        ModelState.AddModelError(nameof(pModel.SessaoID), "Selecione uma seção válida.");
      if (pModel.OperadorResponsavelID.HasValue &&
          _operadorAppService.GetById(pModel.OperadorResponsavelID.Value) == null)
        ModelState.AddModelError(nameof(pModel.OperadorResponsavelID), "Selecione um responsável válido.");
      if (pModel.KmUltimoAbastecimento > pModel.KmAtual)
        ModelState.AddModelError(nameof(pModel.KmUltimoAbastecimento), "O KM do abastecimento não pode ser maior que o KM atual.");

      if (!ModelState.IsValid)
      {
        PopularCombosEdicao();
        return View(pModel);
      }

      try
      {
        viatura.Prefixo = pModel.Prefixo?.Trim();
        viatura.Placa = pModel.Placa?.Trim();
        viatura.PlacaOficial = pModel.PlacaOficial?.Trim();
        viatura.Marca = pModel.Marca.Trim();
        viatura.Modelo = pModel.Modelo.Trim();
        viatura.Ano = pModel.Ano;
        viatura.Chassi = pModel.Chassi?.Trim();
        viatura.SessaoID = pModel.SessaoID;
        viatura.OperadorResponsavelID = pModel.OperadorResponsavelID;
        viatura.TipoCaracterizacao = pModel.TipoCaracterizacao;
        viatura.KmAtual = pModel.KmAtual;
        viatura.KmUltimoAbastecimento = pModel.KmUltimoAbastecimento;
        viatura.KmProximaRevisao = pModel.KmProximaRevisao;

        _viaturaAppService.Update(viatura);
        TempData["Sucesso"] = "Viatura atualizada com sucesso.";
        return RedirectToAction(nameof(Listar));
      }
      catch (Exception ex)
      {
        ModelState.AddModelError(string.Empty, ex.Message);
        PopularCombosEdicao();
        return View(pModel);
      }
    }

    private void PopularCombosEdicao()
    {
      ViewBag.Secoes = _sessaoAppService.GetAll().OrderBy(x => x.Nome)
        .Select(x => new SelectListItem { Value = x.ID.ToString(), Text = x.Nome }).ToList();
      ViewBag.Responsaveis = MontarOperadores().ToList();
    }

    // GET: Viatura/Retirar/5
    [HttpGet]
    public IActionResult Retirar(int pViaturaID)
    {
      var viaturas = _viaturaAppService.PegarViaturas();
      var viatura = viaturas.FirstOrDefault(s => s.ID == pViaturaID);

      if (viatura == null)
        return NotFound();

      var operadorIDLogado = PegarOperadorIDLogado();

      var operadorLogado = operadorIDLogado > 0
        ? _operadorAppService.GetById(operadorIDLogado)
        : null;

      var ultimaMovimentacao = _viaturaMovimentacaoAppService
        .PegarUltimaMovimentacaoViatura(pViaturaID);

      var model = new ViaturaRetiradaViewModel
      {
        DataHora = DateTime.Now,
        NivelCombustivel = ultimaMovimentacao?.NivelCombustivelDevolucao
          ?? ultimaMovimentacao?.NivelCombustivelRetirada
          ?? 50,
        ViaturaID = viatura.ID,
        Prefixo = viatura.Prefixo,
        Placa = viatura.Placa,
        Modelo = viatura.Modelo,
        Secao = viatura.Sessao?.Nome,
        KmAtual = viatura.KmAtual,
        KmProximaRevisao = viatura.KmProximaRevisao,

        OperadorID = operadorLogado?.ID ?? 0,

        OperadorNome = operadorLogado == null
          ? string.Empty
          : MontarNomeOperador(operadorLogado)
      };

      PopularOperadoresPesquisa();

      return View(model);
    }

    private void PopularOperadoresPesquisa()
    {
      var operadores = _operadorAppService
        .GetAll()
        .OrderBy(x => x.Nome)
        .Select(x => new
        {
          id = x.ID,
          nome = x.Nome,
          alcunha = x.Alcunha,
          numerica = x.NumericaDOE,
          descricao = MontarNomeOperador(x)
        })
        .ToList();

      ViewBag.OperadoresJson =
        System.Text.Json.JsonSerializer.Serialize(operadores);
    }

    private string MontarNomeOperador(Operador pOperador)
    {
      if (string.IsNullOrWhiteSpace(pOperador.Alcunha))
        return pOperador.Nome;

      return $"{pOperador.NumericaDOE:00} - {pOperador.Alcunha}";
    }

    // POST: Viatura/Retirar
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Retirar(ViaturaRetiradaViewModel pModel)
    {
      var operadorResponsavelID = PegarOperadorIDLogado();
      if (operadorResponsavelID <= 0 || _operadorAppService.GetById(operadorResponsavelID) == null)
        return Forbid();

      if (pModel.OperadorID == 0 &&
          (!ModelState.TryGetValue(nameof(pModel.OperadorID), out var operadorInformado) ||
           string.IsNullOrWhiteSpace(operadorInformado.AttemptedValue) || operadorInformado.AttemptedValue == "0"))
      {
        pModel.OperadorID = operadorResponsavelID;
        ModelState.Remove(nameof(pModel.OperadorID));
      }

      if (pModel.OperadorID <= 0)
      {
        ModelState.AddModelError(
          nameof(pModel.OperadorID),
          "Selecione um operador.");
      }

      if (!ModelState.IsValid)
      {
        PopularOperadoresPesquisa();

        return View(pModel);
      }

      try
      {
        var movimentacao = new ViaturaMovimentacao
        {
          ViaturaID = pModel.ViaturaID,
          Finalidade = pModel.Finalidade,
          Observacao = pModel.Observacao,
          DataHoraRetirada = pModel.DataHora!.Value,
          NivelCombustivelRetirada = pModel.NivelCombustivel!.Value
        };

        _viaturaMovimentacaoAppService.RetirarViatura(
          movimentacao,
          pModel.OperadorID,
          operadorResponsavelID);

        TempData["Sucesso"] = "Viatura retirada com sucesso.";

        return RedirectToAction(nameof(Listar));
      }
      catch (Exception ex)
      {
        ModelState.AddModelError(string.Empty, ex.Message);

        PopularOperadoresPesquisa();

        return View(pModel);
      }
    }

    // GET: Viatura/Devolver/5
    [HttpGet]
    public IActionResult Devolver(int pViaturaID)
    {
      var viaturas = _viaturaAppService.PegarViaturas();
      var viatura = viaturas.FirstOrDefault(s => s.ID == pViaturaID);

      if (viatura == null)
        return NotFound();

      var operadorIDLogado = PegarOperadorIDLogado();

      var operadorLogado = operadorIDLogado > 0
        ? _operadorAppService.GetById(operadorIDLogado)
        : null;

      var model = new ViaturaDevolucaoViewModel
      {
        DataHora = DateTime.Now,
        NivelCombustivel = 50,
        ViaturaID = viatura.ID,
        Prefixo = viatura.Prefixo,
        Placa = viatura.Placa,
        Modelo = viatura.Modelo,
        KmProximaRevisao = viatura.KmProximaRevisao,
        KmAtual = viatura.KmAtual,

        OperadorID = operadorLogado?.ID ?? 0,

        OperadorNome = operadorLogado == null
          ? string.Empty
          : MontarNomeOperador(operadorLogado)
      };

      PopularOperadoresPesquisa();

      return View(model);
    }

    // POST: Viatura/Devolver
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Devolver(ViaturaDevolucaoViewModel pModel)
    {
      var operadorResponsavelID = PegarOperadorIDLogado();
      if (operadorResponsavelID <= 0 || _operadorAppService.GetById(operadorResponsavelID) == null)
        return Forbid();

      if (pModel.OperadorID == 0 &&
          (!ModelState.TryGetValue(nameof(pModel.OperadorID), out var operadorInformado) ||
           string.IsNullOrWhiteSpace(operadorInformado.AttemptedValue) || operadorInformado.AttemptedValue == "0"))
      {
        pModel.OperadorID = operadorResponsavelID;
        ModelState.Remove(nameof(pModel.OperadorID));
      }

      if (pModel.OperadorID <= 0)
      {
        ModelState.AddModelError(
          nameof(pModel.OperadorID),
          "Selecione um operador.");
      }

      // Se informou que abasteceu, o KM do abastecimento é obrigatório
      if (pModel.Abastecimento && !pModel.KmAbastecimento.HasValue)
      {
        ModelState.AddModelError(
          nameof(pModel.KmAbastecimento),
          "Informe o KM em que a viatura foi abastecida.");
      }

      // O KM do abastecimento não pode ser maior que o KM da devolução
      if (pModel.Abastecimento &&
          pModel.KmAbastecimento.HasValue &&
          pModel.KmFinal.HasValue &&
          pModel.KmAbastecimento.Value > pModel.KmFinal.Value)
      {
        ModelState.AddModelError(
          nameof(pModel.KmAbastecimento),
          "O KM do abastecimento não pode ser maior que o KM da devolução.");
      }

      if (!ModelState.IsValid)
      {
        PopularOperadoresPesquisa();

        return View(pModel);
      }

      try
      {
        _viaturaMovimentacaoAppService.DevolverViatura(
          pModel.ViaturaID,
          pModel.OperadorID,
          pModel.KmFinal.Value,
          pModel.Abastecimento,
          pModel.KmAbastecimento,
          pModel.DataHora!.Value,
          pModel.NivelCombustivel!.Value,
          operadorResponsavelID);

        TempData["Sucesso"] = "Viatura devolvida com sucesso.";

        return RedirectToAction(nameof(Listar));
      }
      catch (Exception ex)
      {
        ModelState.AddModelError(string.Empty, ex.Message);

        PopularOperadoresPesquisa();

        return View(pModel);
      }
    }

    // GET: Viatura/ExibirHistorico/5
    [HttpGet]
    public IActionResult ExibirHistorico(int pViaturaID)
    {
      var viatura = _viaturaAppService.GetById(pViaturaID);

      if (viatura == null)
        return NotFound();

      ViewBag.Viatura = viatura;

      var movimentacoes =
        _viaturaMovimentacaoAppService
          .PegarPorViatura(pViaturaID);

      return View(movimentacoes);
    }

    private int PegarOperadorIDLogado()
    {
      var claim = User.FindFirst("OperadorID");

      if (claim == null)
        return 0;

      int.TryParse(claim.Value, out var operadorID);

      return operadorID;
    }

    private IEnumerable<SelectListItem> MontarOperadores()
    {
      return _operadorAppService
        .GetAll()
        .OrderBy(x => x.Nome)
        .Select(x => new SelectListItem
        {
          Value = x.ID.ToString(),
          Text = string.IsNullOrWhiteSpace(x.Alcunha)
            ? x.Nome
            : $"{x.NumericaDOE:00} - {x.Alcunha}"
        })
        .ToList();
    }
  }
}