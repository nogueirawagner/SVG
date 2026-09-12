using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SVG.App.Interface;
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

    public ViaturaController(
      IViaturaAppService pViaturaAppService,
      IViaturaMovimentacaoAppService pViaturaMovimentacaoAppService,
      IOperadorAppService pOperadorAppService)
    {
      _viaturaAppService = pViaturaAppService;
      _viaturaMovimentacaoAppService = pViaturaMovimentacaoAppService;
      _operadorAppService = pOperadorAppService;
    }

    // GET: Viatura/Listar
    [HttpGet]
    public IActionResult Listar()
    {
      var viaturas = _viaturaAppService.GetAll();

      return View(viaturas);
    }

    // GET: Viatura/Retirar/5
    [HttpGet]
    public IActionResult Retirar(int pViaturaID)
    {
      var viatura = _viaturaAppService.GetById(pViaturaID);

      if (viatura == null)
        return NotFound();

      var operadorIDLogado = PegarOperadorIDLogado();

      var model = new ViaturaRetiradaViewModel
      {
        ViaturaID = viatura.ID,
        Prefixo = viatura.Prefixo,
        Placa = viatura.Placa,
        Modelo = viatura.Modelo,
        Secao = viatura.Sessao?.Nome,
        QuilometragemAtual = viatura.QuilometragemAtual,
        OperadorID = operadorIDLogado,
        Operadores = MontarOperadores()
      };

      return View(model);
    }

    // POST: Viatura/Retirar
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Retirar(ViaturaRetiradaViewModel pModel)
    {
      if (!ModelState.IsValid)
      {
        pModel.Operadores = MontarOperadores();

        return View(pModel);
      }

      try
      {
        var movimentacao = new ViaturaMovimentacao
        {
          ViaturaID = pModel.ViaturaID,
          Finalidade = pModel.Finalidade,
          Observacao = pModel.Observacao
        };

        _viaturaMovimentacaoAppService.RetirarViatura(
          movimentacao,
          pModel.OperadorID);

        TempData["Sucesso"] = "Viatura retirada com sucesso.";

        return RedirectToAction(nameof(Listar));
      }
      catch (Exception ex)
      {
        ModelState.AddModelError(string.Empty, ex.Message);

        pModel.Operadores = MontarOperadores();

        return View(pModel);
      }
    }

    // GET: Viatura/Devolver/5
    [HttpGet]
    public IActionResult Devolver(int pViaturaID)
    {
      var viatura = _viaturaAppService.GetById(pViaturaID);

      if (viatura == null)
        return NotFound();

      var operadorIDLogado = PegarOperadorIDLogado();

      var model = new ViaturaDevolucaoViewModel
      {
        ViaturaID = viatura.ID,
        Prefixo = viatura.Prefixo,
        Placa = viatura.Placa,
        Modelo = viatura.Modelo,
        OperadorID = operadorIDLogado,
        Operadores = MontarOperadores()
      };

      return View(model);
    }

    // POST: Viatura/Devolver
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Devolver(ViaturaDevolucaoViewModel pModel)
    {
      if (!ModelState.IsValid)
      {
        pModel.Operadores = MontarOperadores();

        return View(pModel);
      }

      try
      {
        _viaturaMovimentacaoAppService.DevolverViatura(
          pModel.ViaturaID,
          pModel.OperadorID);

        TempData["Sucesso"] = "Viatura devolvida com sucesso.";

        return RedirectToAction(nameof(Listar));
      }
      catch (Exception ex)
      {
        ModelState.AddModelError(string.Empty, ex.Message);

        pModel.Operadores = MontarOperadores();

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