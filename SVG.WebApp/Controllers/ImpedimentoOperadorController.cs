using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SVG.App.Interface;
using SVG.App.ViewModels;
using SVG.Domain.Entities;

namespace SVG.WebApp.Controllers
{
  [Authorize(Roles = "Admin")]
  public class ImpedimentoOperadorController : Controller
  {
    private readonly IImpedimentoOperadorAppService _impedimentoOperadorAppService;
    private readonly IOperadorAppService _operadorAppService;
    private readonly ISessaoAppService _sessaoAppService;

    public ImpedimentoOperadorController(
      IImpedimentoOperadorAppService impedimentoOperadorAppService,
      IOperadorAppService operadorAppService,
      ISessaoAppService sessaoAppService)
    {
      _impedimentoOperadorAppService = impedimentoOperadorAppService;
      _operadorAppService = operadorAppService;
      _sessaoAppService = sessaoAppService;
    }

    [HttpGet]
    public IActionResult Index(int? pAno)
    {
      var anoSelecionado = pAno ?? DateTime.Now.Year;
      var inicioAno = new DateTime(anoSelecionado, 1, 1);
      var fimAno = new DateTime(anoSelecionado, 12, 31);

      var impedimentos = _impedimentoOperadorAppService
        .PegarPorPeriodo(inicioAno, fimAno)
        .OrderBy(x => x.DataInicio)
        .ThenBy(x => x.Operador?.Nome)
        .ToList();

      var model = new ImpedimentoOperadorListarViewModel
      {
        Ano = anoSelecionado,
        Impedimentos = impedimentos
          .Select(MontarViewModel)
          .ToList()
      };

      PopularFiltros(model);

      return View(model);
    }

    [HttpGet]
    public IActionResult Create()
    {
      var model = new ImpedimentoOperadorViewModel
      {
        DataInicio = DateTime.Now.Date,
        DataFim = null
      };

      PopularCombos();

      return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(
      ImpedimentoOperadorViewModel pModel)
    {
      ValidarPeriodo(pModel);

      if (!ModelState.IsValid)
      {
        PopularCombos();
        return View(pModel);
      }

      try
      {
        var impedimento = new ImpedimentoOperador
        {
          OperadorID = pModel.OperadorID,
          TipoImpedimento = pModel.TipoImpedimento.Value,
          DataInicio = pModel.DataInicio.Date,
          DataFim = pModel.DataFim?.Date,
          Observacao = pModel.Observacao,
          DataHoraCriacao = DateTime.Now
        };

        _impedimentoOperadorAppService.Add(impedimento);

        TempData["Sucesso"] =
          "Impedimento cadastrado com sucesso.";

        return RedirectToAction(nameof(Index));
      }
      catch (Exception ex)
      {
        ModelState.AddModelError(string.Empty, ex.Message);
        PopularCombos();
        return View(pModel);
      }
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
      var impedimento =
        _impedimentoOperadorAppService.GetById(id);

      if (impedimento == null)
        return NotFound();

      var model = MontarViewModel(impedimento);

      PopularCombos();

      return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(
      ImpedimentoOperadorViewModel pModel)
    {
      ValidarPeriodo(pModel);

      if (!ModelState.IsValid)
      {
        PopularCombos();
        return View(pModel);
      }

      var impedimento =
        _impedimentoOperadorAppService.GetById(pModel.ID);

      if (impedimento == null)
        return NotFound();

      try
      {
        impedimento.OperadorID = pModel.OperadorID;
        impedimento.TipoImpedimento =
          pModel.TipoImpedimento.Value;
        impedimento.DataInicio = pModel.DataInicio.Date;
        impedimento.DataFim = pModel.DataFim?.Date;
        impedimento.Observacao = pModel.Observacao;

        _impedimentoOperadorAppService.Update(impedimento);

        TempData["Sucesso"] =
          "Impedimento atualizado com sucesso.";

        return RedirectToAction(nameof(Index));
      }
      catch (Exception ex)
      {
        ModelState.AddModelError(string.Empty, ex.Message);
        PopularCombos();
        return View(pModel);
      }
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
      var impedimento =
        _impedimentoOperadorAppService.GetById(id);

      if (impedimento == null)
        return NotFound();

      return View(MontarViewModel(impedimento));
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
      var impedimento =
        _impedimentoOperadorAppService.GetById(id);

      if (impedimento == null)
        return NotFound();

      try
      {
        _impedimentoOperadorAppService.Remove(impedimento);

        TempData["Sucesso"] =
          "Impedimento excluído com sucesso.";

        return RedirectToAction(nameof(Index));
      }
      catch (Exception ex)
      {
        TempData["Erro"] = ex.Message;

        return RedirectToAction(
          nameof(Delete),
          new { id });
      }
    }

    private void ValidarPeriodo(
      ImpedimentoOperadorViewModel pModel)
    {
      if (pModel.DataFim.HasValue &&
          pModel.DataFim.Value.Date <
          pModel.DataInicio.Date)
      {
        ModelState.AddModelError(
          nameof(pModel.DataFim),
          "A data final não pode ser anterior à data inicial.");
      }

      if (pModel.OperadorID <= 0)
      {
        ModelState.AddModelError(
          nameof(pModel.OperadorID),
          "Selecione um operador.");
      }
    }

    private ImpedimentoOperadorViewModel MontarViewModel(
      ImpedimentoOperador pImpedimento)
    {
      var operador =
        pImpedimento.Operador ??
        _operadorAppService.GetById(pImpedimento.OperadorID);

      var secao = operador?.Sessao ??
        (operador != null
          ? _sessaoAppService.GetById(operador.SessaoID)
          : null);

      return new ImpedimentoOperadorViewModel
      {
        ID = pImpedimento.ID,
        OperadorID = pImpedimento.OperadorID,
        TipoImpedimento = pImpedimento.TipoImpedimento,
        DataInicio = pImpedimento.DataInicio,
        DataFim = pImpedimento.DataFim,
        Observacao = pImpedimento.Observacao,
        DataHoraCriacao = pImpedimento.DataHoraCriacao,
        OperadorNome = operador?.Nome,
        SessaoNome = secao?.Nome
      };
    }

    private void PopularCombos()
    {
      ViewBag.Operadores = _operadorAppService
        .GetAll()
        .OrderBy(x => x.Nome)
        .Select(x => new SelectListItem
        {
          Value = x.ID.ToString(),
          Text = MontarNomeOperador(x)
        })
        .ToList();
    }

    private void PopularFiltros(
      ImpedimentoOperadorListarViewModel pModel)
    {
      pModel.Operadores = _operadorAppService
        .GetAll()
        .OrderBy(x => x.Nome)
        .Select(x => new SelectListItem
        {
          Value = x.ID.ToString(),
          Text = MontarNomeOperador(x)
        })
        .ToList();

      pModel.Sessoes = _sessaoAppService
        .GetAll()
        .OrderBy(x => x.Nome)
        .Select(x => new SelectListItem
        {
          Value = x.ID.ToString(),
          Text = x.Nome
        })
        .ToList();

      var anos = _impedimentoOperadorAppService
        .PegarAnosComImpedimentos()
        .ToList();

      if (!anos.Contains(DateTime.Now.Year))
        anos.Add(DateTime.Now.Year);

      anos = anos
        .Distinct()
        .OrderByDescending(x => x)
        .ToList();

      pModel.Anos = anos
        .Select(x => new SelectListItem
        {
          Value = x.ToString(),
          Text = x.ToString()
        })
        .ToList();
    }

    private string MontarNomeOperador(
      Operador pOperador)
    {
      if (string.IsNullOrWhiteSpace(pOperador.Alcunha))
        return pOperador.Nome;

      return
        $"{pOperador.NumericaDOE:00} - {pOperador.Alcunha}";
    }
  }
}
