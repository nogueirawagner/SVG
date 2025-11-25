using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SVG.App.Interface;
using SVG.App.Services;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.Operador;

namespace SVG.WebApp.Controllers
{
  public class OperacaoController : Controller
  {
    private readonly IOperacaoAppService _operacaoAppService;
    private readonly IOperadorAppService _operadorAppService;
    private readonly ISessaoAppService _sessaoAppService;
    private readonly ITipoOperacaoAppService _tipoOperacaoAppService;
    private readonly IMapper _mapper;

    public OperacaoController(
      IOperacaoAppService operacaoAppService,
      IOperadorAppService operadorAppService,
      ITipoOperacaoAppService tipoOperacaoAppService,
      ISessaoAppService sessaoAppService,
      IMapper mapper)
    {
      _operacaoAppService = operacaoAppService;
      _operadorAppService = operadorAppService;
      _tipoOperacaoAppService = tipoOperacaoAppService;
      _sessaoAppService = sessaoAppService;
      _mapper = mapper;
    }

    private void PopularCombos(int? tipoOperacaoId = null, int? coordenadorId = null)
    {
      var operadores = _operadorAppService
          .GetAll()
          .OrderBy(o => o.Nome)
          .ToList();

      ViewBag.Coordenadores = operadores;

      var operadoresDto = operadores.Select(o => new
      {
        o.ID,
        o.Nome,
        o.Matricula,
        o.SessaoID
      }).ToList();

      ViewBag.OperadoresJson = JsonConvert.SerializeObject(operadoresDto);

      // >>> SESSÕES
      var sessoes = _sessaoAppService
          .GetAll()
          .OrderBy(s => s.Nome)
          .ToList();
      ViewBag.Sessoes = sessoes;

      // >>> TIPOS
      var tipos = _tipoOperacaoAppService
          .GetAll()
          .OrderBy(t => t.Nome)
          .ToList();
      ViewBag.TiposOperacao = tipos;
    }


    // GET: Operacao
    public IActionResult Index(string search)
    {
      var operacoes = _operacaoAppService.GetAll();

      if (!string.IsNullOrWhiteSpace(search))
      {
        operacoes = operacoes
          .Where(o => o.Objeto.Contains(search, StringComparison.OrdinalIgnoreCase)
                   || o.Coordenador.Contains(search, StringComparison.OrdinalIgnoreCase));
      }

      var lista = operacoes
        .OrderByDescending(o => o.DataHora)
        .ToList();

      var vm = _mapper.Map<IEnumerable<Operacao>, IEnumerable<OperacaoViewModel>>(lista);

      ViewData["search"] = search;

      return View(vm);
    }

    // GET: Operacao/Details/5
    public IActionResult Details(int id)
    {
      var operacao = _operacaoAppService.GetById(id);
      if (operacao == null) return NotFound();

      var vm = _mapper.Map<OperacaoViewModel>(operacao);
      return View(vm);
    }

    // GET: Operacao/Create
    public IActionResult Create()
    {
      PopularCombos();

      var now = DateTime.Now;
      var date = new DateTime(now.Year, now.Month, now.Day, 03, 00, 00);

      return View(new OperacaoViewModel
      {
        DataHora = date
      });
    }

    // POST: Operacao/Create
    [HttpPost]
    //[ValidateAntiForgeryToken]
    public IActionResult Create(OperacaoViewModel model)
    {
      ModelState.Remove("Coordenador");
      ModelState.Remove("TipoOperacaoNome");


      if (!ModelState.IsValid)
      {
        PopularCombos(model.TipoOperacaoID, model.CoordenadorOperadorID);
        return View(model);
      }

      // Exemplo: pegar o nome do coordenador a partir do ID selecionado
      var coord = _operadorAppService.GetById(model.CoordenadorOperadorID);
      if (coord != null)
        model.Coordenador = coord.Nome;

      var entidade = _mapper.Map<Operacao>(model);

      // Aqui você ainda pode, depois, percorrer model.OperadoresSelecionados
      // e criar os registros de OperadorOperacao.
      var opSvg = model.OperadoresSelecionados.Where(s => s.SVG).Select(x => x.OperadorID).ToList();

      var dataBase = DateTime.Now.AddMonths(-1); // 30 dias.

      var operadoresContemplados = _operacaoAppService.PegarOperadoresSVG(opSvg.ToArray(), dataBase, model.QtdVagasVoluntarios.Value);
      var operadoresSessao = model.OperadoresSelecionados.Where(s => !s.SVG).ToList();

      var operadoresSVG = opSvg.Where(id => operadoresContemplados.Contains(id)).ToList();

      operadoresSessao.AddRange(operadoresSVG.Select(id => new OperadorSelecionadoVM
      {
        OperadorID = id,
        SVG = true
      }));

      // gravar
      _operacaoAppService.Add(entidade);

      return RedirectToAction(nameof(Index));
    }


    // GET: Operacao/Edit/5
    public IActionResult Edit(int id)
    {
      var operacao = _operacaoAppService.GetById(id);
      if (operacao == null) return NotFound();

      var vm = _mapper.Map<OperacaoViewModel>(operacao);
      PopularTiposOperacaoDropDown(vm.TipoOperacaoID);

      return View(vm);
    }

    // POST: Operacao/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(OperacaoViewModel model)
    {
      if (!ModelState.IsValid)
      {
        PopularTiposOperacaoDropDown(model.TipoOperacaoID);
        return View(model);
      }

      var entidade = _mapper.Map<Operacao>(model);
      _operacaoAppService.Update(entidade);

      return RedirectToAction(nameof(Index));
    }

    // GET: Operacao/Delete/5
    public IActionResult Delete(int id)
    {
      var operacao = _operacaoAppService.GetById(id);
      if (operacao == null) return NotFound();

      var vm = _mapper.Map<OperacaoViewModel>(operacao);
      return View(vm);
    }

    // POST: Operacao/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
      var operacao = _operacaoAppService.GetById(id);
      if (operacao == null) return NotFound();

      _operacaoAppService.Remove(operacao);
      return RedirectToAction(nameof(Index));
    }

    private void PopularTiposOperacaoDropDown(int? selecionado = null)
    {
      var tipos = _tipoOperacaoAppService.GetAll()
        .OrderBy(t => t.Nome)
        .ToList();

      ViewBag.TipoOperacaoID =
        new SelectList(tipos, "ID", "Nome", selecionado);
    }
  }
}
