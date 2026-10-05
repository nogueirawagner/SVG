using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SVG.App.Interface;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperador;
using SVG.WebApp.Configurations;
using SVG.WebApp.Models;

namespace SVG.WebApp.Controllers
{
  
  public class AfastamentoOperadorController : Controller
  {
    private readonly IAfastamentoOperadorAppService _afastamentoOperadorAppService;
    private readonly IOperadorAppService _operadorAppService;
    private readonly ISessaoAppService _sessaoAppService;
    private readonly IUserContext _userContext;

    public AfastamentoOperadorController(
      IAfastamentoOperadorAppService afastamentoOperadorAppService,
      IOperadorAppService operadorAppService,
      ISessaoAppService sessaoAppService,
      IUserContext userContext)
    {
      _afastamentoOperadorAppService = afastamentoOperadorAppService;
      _operadorAppService = operadorAppService;
      _sessaoAppService = sessaoAppService;
      _userContext = userContext;
    }

    // ============================================================
    // LISTAR
    // ============================================================

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult Index(int? pAno)
    {
      /*
       * O ano é o único filtro processado no servidor.
       * Na primeira abertura usamos o ano atual.
       */
      var anoSelecionado = pAno ?? DateTime.Now.Year;

      var inicioAno = new DateTime(
        anoSelecionado,
        1,
        1);

      var fimAno = new DateTime(
        anoSelecionado,
        12,
        31);

      /*
       * A consulta por período é executada no Repository/SQL.
       * Assim, somente os afastamentos que interceptam o ano
       * selecionado são enviados para o navegador.
       */
      var afastamentos = _afastamentoOperadorAppService
        .PegarPorPeriodo(inicioAno, fimAno)
        .OrderBy(x => x.DataInicio)
        .ThenBy(x => x.Operador?.Nome)
        .ToList();

      var model = new AfastamentoOperadorListarViewModel
      {
        Ano = anoSelecionado,

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
    [Authorize(Roles = "Admin")]
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

    [Authorize(Roles = "Operador")]
    [HttpGet]
    public ActionResult AfastamentosSecao(int? mes, int? ano)
    {
      var hoje = DateTime.Today;

      var mesSelecionado = mes ?? hoje.Month;
      var anoSelecionado = ano ?? hoje.Year;

      var operadorLogado = _operadorAppService.GetById(_userContext.OperadorId.Value);
      var secao = _sessaoAppService.GetById(operadorLogado.SessaoID);

      ViewBag.Secao = secao.Nome;

      if (operadorLogado == null)
        return NotFound();

      var secaoId = operadorLogado.SessaoID;

      var inicioMes = new DateTime(anoSelecionado, mesSelecionado, 1);
      var fimMes = inicioMes.AddMonths(1).AddDays(-1);

      var afastamentos = _afastamentoOperadorAppService
          .ObterPorSecaoEPeriodo(secaoId, inicioMes, fimMes);

      var model = new AfastamentosSecaoViewModel
      {
        Mes = mesSelecionado,
        Ano = anoSelecionado,
        SecaoID = secaoId,
        Afastamentos = afastamentos
      };

      return View(model);
    }

    // ============================================================
    // CREATE - POST
    // ============================================================
    [Authorize(Roles = "Admin")]
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
    [Authorize(Roles = "Admin")]
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
    [Authorize(Roles = "Admin")]
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
    [Authorize(Roles = "Admin")]
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
    [Authorize(Roles = "Admin")]
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
      var operador = _operadorAppService.GetById(pAfastamento.OperadorID);
      var secao = _sessaoAppService.GetById(operador.SessaoID);

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

        OperadorNome = operador.Nome,

        SessaoNome = secao.Nome
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

      var anos = _afastamentoOperadorAppService
      .PegarAnosComAfastamentos()
      .ToList();

      /*
       * O ano atual deve estar sempre disponível porque é
       * o ano padrão da tela, mesmo que ainda não exista
       * afastamento cadastrado nele.
       */
      if (!anos.Contains(DateTime.Now.Year))
      {
        anos.Add(DateTime.Now.Year);
      }

      anos = anos
        .Distinct()
        .OrderByDescending(x => x)
        .ToList();

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