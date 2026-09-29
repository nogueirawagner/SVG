using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SVG.App.Interface;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperador;

namespace SVG.WebApp.Controllers
{
  [Authorize(Roles = "Admin")]
  public class AfastamentoOperadorController : Controller
  {
    private readonly IAfastamentoOperadorAppService _afastamentoOperadorAppService;
    private readonly IOperadorAppService _operadorAppService;
    private readonly ISessaoAppService _sessaoAppService;

    public AfastamentoOperadorController(
      IAfastamentoOperadorAppService afastamentoOperadorAppService,
      IOperadorAppService operadorAppService,
      ISessaoAppService sessaoAppService)
    {
      _afastamentoOperadorAppService = afastamentoOperadorAppService;
      _operadorAppService = operadorAppService;
      _sessaoAppService = sessaoAppService;
    }

    // ============================================================
    // LISTAR
    // ============================================================

    [HttpGet]
    public IActionResult Index(
      int? pOperadorID,
      int? pSessaoID,
      XTipoAfastamento? pTipoAfastamento,
      int? pAno,
      int? pMes,
      DateTime? pPeriodoInicio,
      DateTime? pPeriodoFim)
    {
      var afastamentos = _afastamentoOperadorAppService
        .PegarAfastamentos()
        .ToList();

      // =========================
      // OPERADOR
      // =========================

      if (pOperadorID.HasValue)
      {
        afastamentos = afastamentos
          .Where(x => x.OperadorID == pOperadorID.Value)
          .ToList();
      }

      // =========================
      // SEÇÃO
      // =========================

      if (pSessaoID.HasValue)
      {
        afastamentos = afastamentos
          .Where(x =>
            x.Operador != null &&
            x.Operador.SessaoID == pSessaoID.Value)
          .ToList();
      }

      // =========================
      // TIPO
      // =========================

      if (pTipoAfastamento.HasValue)
      {
        afastamentos = afastamentos
          .Where(x =>
            x.TipoAfastamento == pTipoAfastamento.Value)
          .ToList();
      }

      // =========================
      // ANO
      // =========================

      if (pAno.HasValue)
      {
        var inicioAno = new DateTime(
          pAno.Value,
          1,
          1);

        var fimAno = new DateTime(
          pAno.Value,
          12,
          31);

        afastamentos = afastamentos
          .Where(x =>
            x.DataInicio.Date <= fimAno &&
            x.DataFim.Date >= inicioAno)
          .ToList();
      }

      // =========================
      // MÊS
      // =========================

      if (pMes.HasValue)
      {
        var anoMes = pAno ?? DateTime.Now.Year;

        var inicioMes = new DateTime(
          anoMes,
          pMes.Value,
          1);

        var fimMes = inicioMes
          .AddMonths(1)
          .AddDays(-1);

        afastamentos = afastamentos
          .Where(x =>
            x.DataInicio.Date <= fimMes &&
            x.DataFim.Date >= inicioMes)
          .ToList();
      }

      // =========================
      // PERÍODO
      // =========================

      if (pPeriodoInicio.HasValue)
      {
        afastamentos = afastamentos
          .Where(x =>
            x.DataFim.Date >= pPeriodoInicio.Value.Date)
          .ToList();
      }

      if (pPeriodoFim.HasValue)
      {
        afastamentos = afastamentos
          .Where(x =>
            x.DataInicio.Date <= pPeriodoFim.Value.Date)
          .ToList();
      }

      afastamentos = afastamentos
        .OrderBy(x => x.DataInicio)
        .ThenBy(x => x.Operador?.Nome)
        .ToList();

      var model = new AfastamentoOperadorListarViewModel
      {
        OperadorID = pOperadorID,
        SessaoID = pSessaoID,
        TipoAfastamento = pTipoAfastamento,
        Ano = pAno,
        Mes = pMes,
        PeriodoInicio = pPeriodoInicio,
        PeriodoFim = pPeriodoFim,

        Afastamentos = afastamentos
          .Select(MontarViewModel)
          .ToList()
      };

      PopularFiltros(model);

      return View(model);
    }

    // ============================================================
    // CREATE - GET
    // ============================================================

    [HttpGet]
    public IActionResult Create()
    {
      var model = new AfastamentoOperadorViewModel
      {
        DataInicio = DateTime.Now.Date,
        DataFim = DateTime.Now.Date
      };

      PopularCombos();

      return View(model);
    }

    // ============================================================
    // CREATE - POST
    // ============================================================

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(
      AfastamentoOperadorViewModel pModel)
    {
      ValidarPeriodo(pModel);

      if (!ModelState.IsValid)
      {
        PopularCombos();

        return View(pModel);
      }

      try
      {
        var afastamento = new AfastamentoOperador
        {
          OperadorID = pModel.OperadorID,
          TipoAfastamento = pModel.TipoAfastamento.Value,
          DataInicio = pModel.DataInicio.Date,
          DataFim = pModel.DataFim.Date,
          Observacao = pModel.Observacao,
          DataHoraCriacao = DateTime.Now
        };

        _afastamentoOperadorAppService.Add(afastamento);

        TempData["Sucesso"] =
          "Afastamento cadastrado com sucesso.";

        return RedirectToAction(nameof(Index));
      }
      catch (Exception ex)
      {
        ModelState.AddModelError(
          string.Empty,
          ex.Message);

        PopularCombos();

        return View(pModel);
      }
    }

    // ============================================================
    // EDIT - GET
    // ============================================================

    [HttpGet]
    public IActionResult Edit(int id)
    {
      var afastamento =
        _afastamentoOperadorAppService.GetById(id);

      if (afastamento == null)
        return NotFound();

      var model = MontarViewModel(afastamento);

      PopularCombos();

      return View(model);
    }

    // ============================================================
    // EDIT - POST
    // ============================================================

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(
      AfastamentoOperadorViewModel pModel)
    {
      ValidarPeriodo(pModel);

      if (!ModelState.IsValid)
      {
        PopularCombos();

        return View(pModel);
      }

      var afastamento =
        _afastamentoOperadorAppService
          .GetById(pModel.ID);

      if (afastamento == null)
        return NotFound();

      try
      {
        afastamento.OperadorID =
          pModel.OperadorID;

        afastamento.TipoAfastamento =
          pModel.TipoAfastamento.Value;

        afastamento.DataInicio =
          pModel.DataInicio.Date;

        afastamento.DataFim =
          pModel.DataFim.Date;

        afastamento.Observacao =
          pModel.Observacao;

        /*
         * DataHoraCriacao NÃO é alterada.
         */

        _afastamentoOperadorAppService
          .Update(afastamento);

        TempData["Sucesso"] =
          "Afastamento atualizado com sucesso.";

        return RedirectToAction(nameof(Index));
      }
      catch (Exception ex)
      {
        ModelState.AddModelError(
          string.Empty,
          ex.Message);

        PopularCombos();

        return View(pModel);
      }
    }

    // ============================================================
    // DELETE - GET
    // ============================================================

    [HttpGet]
    public IActionResult Delete(int id)
    {
      var afastamento =
        _afastamentoOperadorAppService
          .GetById(id);

      if (afastamento == null)
        return NotFound();

      var model =
        MontarViewModel(afastamento);

      return View(model);
    }

    // ============================================================
    // DELETE - POST
    // ============================================================

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
      var afastamento =
        _afastamentoOperadorAppService
          .GetById(id);

      if (afastamento == null)
        return NotFound();

      try
      {
        _afastamentoOperadorAppService
          .Remove(afastamento);

        TempData["Sucesso"] =
          "Afastamento excluído com sucesso.";

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

    // ============================================================
    // VALIDAÇÕES
    // ============================================================

    private void ValidarPeriodo(
      AfastamentoOperadorViewModel pModel)
    {
      if (pModel.DataFim.Date <
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

    // ============================================================
    // VIEW MODEL
    // ============================================================

    private AfastamentoOperadorViewModel MontarViewModel(
      AfastamentoOperador pAfastamento)
    {
      return new AfastamentoOperadorViewModel
      {
        ID = pAfastamento.ID,

        OperadorID =
          pAfastamento.OperadorID,

        TipoAfastamento =
          pAfastamento.TipoAfastamento,

        DataInicio =
          pAfastamento.DataInicio,

        DataFim =
          pAfastamento.DataFim,

        Observacao =
          pAfastamento.Observacao,

        DataHoraCriacao =
          pAfastamento.DataHoraCriacao,

        OperadorNome =
          pAfastamento.Operador == null
            ? string.Empty
            : MontarNomeOperador(
              pAfastamento.Operador),

        SessaoNome =
          pAfastamento.Operador?.Sessao?.Nome
      };
    }

    // ============================================================
    // COMBOS CREATE / EDIT
    // ============================================================

    private void PopularCombos()
    {
      var operadores = _operadorAppService
        .GetAll()
        .OrderBy(x => x.Nome)
        .Select(x => new SelectListItem
        {
          Value = x.ID.ToString(),

          Text = MontarNomeOperador(x)
        })
        .ToList();

      ViewBag.Operadores = operadores;
    }

    // ============================================================
    // FILTROS INDEX
    // ============================================================

    private void PopularFiltros(
      AfastamentoOperadorListarViewModel pModel)
    {
      pModel.Operadores =
        _operadorAppService
          .GetAll()
          .OrderBy(x => x.Nome)
          .Select(x => new SelectListItem
          {
            Value = x.ID.ToString(),

            Text = MontarNomeOperador(x)
          })
          .ToList();

      pModel.Sessoes =
        _sessaoAppService
          .GetAll()
          .OrderBy(x => x.Nome)
          .Select(x => new SelectListItem
          {
            Value = x.ID.ToString(),
            Text = x.Nome
          })
          .ToList();

      var anos =
        _afastamentoOperadorAppService
          .PegarAfastamentos()
          .SelectMany(x =>
            Enumerable.Range(
              x.DataInicio.Year,
              x.DataFim.Year -
              x.DataInicio.Year + 1))
          .Distinct()
          .OrderByDescending(x => x)
          .ToList();

      /*
       * Se ainda não existe afastamento cadastrado,
       * precisamos permitir o ano atual.
       */
      if (!anos.Any())
      {
        anos.Add(DateTime.Now.Year);
      }

      pModel.Anos =
        anos.Select(x =>
          new SelectListItem
          {
            Value = x.ToString(),
            Text = x.ToString()
          })
          .ToList();
    }

    // ============================================================
    // NOME OPERADOR
    // ============================================================

    private string MontarNomeOperador(
      Operador pOperador)
    {
      if (string.IsNullOrWhiteSpace(
        pOperador.Alcunha))
      {
        return pOperador.Nome;
      }

      return
        $"{pOperador.NumericaDOE:00} - {pOperador.Alcunha}";
    }
  }
}