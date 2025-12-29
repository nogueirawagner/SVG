using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SVG.App.Interface;
using SVG.App.Services;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.TiposOperador;

namespace SVG.WebApp.Controllers
{
  public class OperacaoController : Controller
  {
    private readonly IOperacaoAppService _operacaoAppService;
    private readonly IOperadorOperacaoAppService _operadorOperacaoAppService;
    private readonly IOperadorAppService _operadorAppService;
    private readonly ISessaoAppService _sessaoAppService;
    private readonly ITipoOperacaoAppService _tipoOperacaoAppService;
    private readonly IMapper _mapper;

    public OperacaoController(
      IOperacaoAppService operacaoAppService,
      IOperadorAppService operadorAppService,
      ITipoOperacaoAppService tipoOperacaoAppService,
      ISessaoAppService sessaoAppService,
      IOperadorOperacaoAppService operadorOperacaoAppService,
      IMapper mapper)
    {
      _operacaoAppService = operacaoAppService;
      _operadorAppService = operadorAppService;
      _tipoOperacaoAppService = tipoOperacaoAppService;
      _sessaoAppService = sessaoAppService;
      _operadorOperacaoAppService = operadorOperacaoAppService;
      _mapper = mapper;
    }

    private void PopularCombos(int? tipoOperacaoId = null, int? coordenadorId = null)
    {
      // =====================
      // OPERADORES / COORDENADORES
      // =====================
      var operadores = _operadorAppService
          .GetAll()
          .OrderBy(o => o.Nome)
          .ToList();

      ViewBag.Coordenadores = operadores;

      // Valor selecionado (coordenador)
      ViewBag.CoordenadorID = coordenadorId;

      // JSON usado nos selects dinâmicos (operadores voluntários etc)
      var operadoresDto = operadores.Select(o => new
      {
        o.ID,
        o.Nome,
        o.Matricula,
        o.SessaoID
      }).ToList();

      ViewBag.OperadoresJson = JsonConvert.SerializeObject(operadoresDto);


      // =====================
      // SESSÕES (lado esquerdo do Create)
      // =====================
      var sessoes = _sessaoAppService
          .GetAll()
          .OrderBy(s => s.Nome)
          .ToList();

      ViewBag.Sessoes = sessoes;
      ViewBag.SessaoSelecionadaId = sessoes.FirstOrDefault()?.ID ?? 0;


      // =====================
      // TIPOS DE OPERAÇÃO
      // =====================
      var tipos = _tipoOperacaoAppService
          .GetAll()
          .OrderBy(t => t.Nome)
          .ToList();

      ViewBag.TiposOperacao = tipos;

      // Valor selecionado (tipo da operação)
      ViewBag.TipoOperacaoID = tipoOperacaoId;
    }

    // GET: Operacao
    public IActionResult Index(string search)
    {
      var operacoes = _operacaoAppService.PegarOperacoesRealizadas().ToList();
      return View(operacoes);
    }

    [HttpPost]
    public IActionResult AlterarSVGOperador(int pOperadorID, bool pSVG)
    {
      _operacaoAppService.AlterarSVGOperador(pOperadorID, pSVG);
      return Ok();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EncerrarSVG(int pOperacaoID)
    {
      var oper = _operacaoAppService.GetById(pOperacaoID);
      oper.SvgAberto = false;
      oper.QtdVagasRestantes = 0;

      _operacaoAppService.Update(oper);
      return RedirectToAction("Index"); ;
    }

    // GET: Operacao/Details/5
    public IActionResult DetalhesOperacao(int pOperacaoID)
    {
      var detalhes = _operacaoAppService.PegarDetalhesOperacao(pOperacaoID).ToList();

      return View(detalhes);
    }

    public IActionResult PegarOperacoesSVGAberto()
    {
      PopularCombos();

      var operacoesSVG = _operacaoAppService.PegarOperacoesSVGAberto().ToList();
      var grupos = operacoesSVG
        .GroupBy(o => o.TipoOperacao)
        .Select(g => new
        {
          TipoOperacao = g.Key,
          Operacoes = g.ToList()
        })
        .ToList();

      ViewBag.GruposTipoOperacao = grupos;


      return View(operacoesSVG);
    }

    [HttpGet]
    public ActionResult PegaCandidatoSVG(int pOperacaoID)
    {
      var lista = _operacaoAppService.PegaCandidatoSVG(pOperacaoID);
      return Json(lista);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public void InsereCandidatoSVG(int pOperacaoID, int pOperadorID)
    {
      _operacaoAppService.InsereCandidatoSVG(pOperacaoID, pOperadorID);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public void RemoveCandidatoSVG(int pOperacaoID, int pOperadorID)
    {
      _operacaoAppService.RemoveCandidatoSVG(pOperacaoID, pOperadorID);
    }

    public IActionResult CreateReforcoPlantao()
    {
      var model = new OperacaoViewModel();
      PopularCombos();

      var now = DateTime.Now.AddDays(2);
      var date = new DateTime(now.Year, now.Month, now.Day, 03, 00, 00);
      
      model.DataHora = date;
      model.DataHoraInicio = date;
      model.DataHoraFim = date.AddDays(1);
      model.TipoOperacaoID = 4;
      model.SvgAberto = true;
      model.Objeto = "Segurança Orgânica";

      return View(model);
    }


    // POST: Operacao/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateReforcoPlantao(OperacaoViewModel model)
    {
      ModelState.Remove("Coordenador");
      ModelState.Remove("TipoOperacaoNome");
      ModelState.Remove("OperadoresSelecionados.Nome");
      ModelState.Remove("OperadoresSelecionados.Matricula");
      ModelState.Remove("OperadoresSelecionados.Telefone");
      ModelState.Remove("OperadoresSelecionados.Sessao");
      ModelState.Remove("QtdVagasRestantes");

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
      entidade.DataHoraCriacao = DateTime.Now;
      entidade.DataHora = model.DataHoraInicio;
      
      entidade.OrdemServico = string.Concat("OS ", model.OrdemServico);

      var opSvg = model.OperadoresSelecionados.Where(s => s.SVG).Select(x => x.OperadorID).ToList();
      var dataBase = DateTime.Now.AddMonths(-1); // 30 dias.

      var operadoresContemplados = new List<int>();
      if (opSvg.Count > 0)
      {
        if (opSvg.Count > model.QtdVagasVoluntarios)
        {
          if (model.QtdVagasVoluntarios == 0)
            model.QtdVagasVoluntarios = opSvg.Count;

          operadoresContemplados = _operacaoAppService.PegarOperadoresSVG(opSvg.ToArray(), dataBase, model.QtdVagasVoluntarios).ToList();
        }
        else
          operadoresContemplados = opSvg;
      }

      var operadoresOperacao = model.OperadoresSelecionados.Where(s => !s.SVG).ToList();

      var operadoresSVG = opSvg.Where(id => operadoresContemplados.Contains(id)).ToList();

      operadoresOperacao.AddRange(operadoresSVG.Select(id => new OperadorSelecionadoVM
      {
        OperadorID = id,
        SVG = true
      }));

      _operacaoAppService.Add(entidade);

      var qtdRestante = model.QtdVagasVoluntarios - operadoresSVG.Count;
      entidade.QtdVagasRestantes = qtdRestante < 0 ? 0 : qtdRestante;
      entidade.SvgAberto = qtdRestante > 0 ? true : false;

      foreach (var op in operadoresOperacao)
      {
        var operadorOperacao = new OperadorOperacao
        {
          OperacaoID = entidade.ID,
          OperadorID = op.OperadorID,
          SVG = op.SVG
        };
        _operadorOperacaoAppService.Add(operadorOperacao);
      }

      return RedirectToAction(nameof(Index));
    }

    // GET: Operacao/Create
    public IActionResult Create()
    {
      var model = new OperacaoViewModel();
      PopularCombos();

      var now = DateTime.Now.AddDays(2);
      var date = new DateTime(now.Year, now.Month, now.Day, 03, 00, 00);

      model.DataHora = date;
      model.TipoOperacaoID = 1;
      model.SvgAberto = true;
      

      return View(model);
    }

    // POST: Operacao/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OperacaoViewModel model)
    {
      ModelState.Remove("Coordenador");
      ModelState.Remove("TipoOperacaoNome");
      ModelState.Remove("OperadoresSelecionados.Nome");
      ModelState.Remove("OperadoresSelecionados.Matricula");
      ModelState.Remove("OperadoresSelecionados.Telefone");
      ModelState.Remove("OperadoresSelecionados.Sessao");
      ModelState.Remove("QtdVagasRestantes");

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
      entidade.DataHoraCriacao = DateTime.Now;
      entidade.OrdemServico = string.Concat("OS ", model.OrdemServico);
      entidade.DataHoraInicio = null;
      entidade.DataHoraFim = null;

      var opSvg = model.OperadoresSelecionados.Where(s => s.SVG).Select(x => x.OperadorID).ToList();
      var dataBase = DateTime.Now.AddMonths(-1); // 30 dias.

      var operadoresContemplados = new List<int>();
      if (opSvg.Count > 0)
      {
        if (opSvg.Count > model.QtdVagasVoluntarios)
        {
          if (model.QtdVagasVoluntarios == 0)
            model.QtdVagasVoluntarios = opSvg.Count;

          operadoresContemplados = _operacaoAppService.PegarOperadoresSVG(opSvg.ToArray(), dataBase, model.QtdVagasVoluntarios).ToList();
        }
        else
          operadoresContemplados = opSvg;
      }

      var operadoresOperacao = model.OperadoresSelecionados.Where(s => !s.SVG).ToList();

      var operadoresSVG = opSvg.Where(id => operadoresContemplados.Contains(id)).ToList();

      operadoresOperacao.AddRange(operadoresSVG.Select(id => new OperadorSelecionadoVM
      {
        OperadorID = id,
        SVG = true
      }));

      _operacaoAppService.Add(entidade);

      var qtdRestante = model.QtdVagasVoluntarios - operadoresSVG.Count;
      entidade.QtdVagasRestantes = qtdRestante < 0 ? 0 : qtdRestante;
      entidade.SvgAberto = qtdRestante > 0 ? true : false;

      foreach (var op in operadoresOperacao)
      {
        var operadorOperacao = new OperadorOperacao
        {
          OperacaoID = entidade.ID,
          OperadorID = op.OperadorID,
          SVG = op.SVG
        };
        _operadorOperacaoAppService.Add(operadorOperacao);
      }

      return RedirectToAction(nameof(Index));
    }

    // GET: Operacao/Edit/5
    public IActionResult Edit(int id)
    {
      var operacao = _operacaoAppService.GetById(id);
      if (operacao == null)
        return NotFound();

      var vm = _mapper.Map<OperacaoViewModel>(operacao);

      // coordenador → achar por nome
      var coord = _operadorAppService
          .GetAll()
          .FirstOrDefault(o => o.Nome == operacao.Coordenador);

      if (coord != null)
        vm.CoordenadorOperadorID = coord.ID;

      // vamos precisar dos operadores completos (VM) pra montar Nome/Matricula/etc
      var operadoresVM = _operadorAppService
          .GetAll()
          .ToList();

      //// vamos precisar dos operadores completos (VM) pra montar Nome/Matricula/etc
      //var operadoresVM = _operadorAppService
      //    .GetAll()
      //    .ToList();

      //// vínculos OperadorOperacao dessa operação
      //var vinculos = _operadorOperacaoAppService
      //    .GetAll()
      //    .Where(oo => oo.OperacaoID == id)
      //    .ToList();

      //vm.OperadoresSelecionados = (
      //    from oo in vinculos
      //    join op in operadoresVM on oo.OperadorID equals op.ID
      //    select new OperadorSelecionado
      //    {
      //      OperadorID = op.ID,
      //      SVG = oo.SVG,
      //      Nome = op.Nome,
      //      Matricula = op.Matricula,
      //      Telefone = op.Telefone,
      //      //Sessao = op.Sessao.Nome 
      //    }
      //).ToList();

      PopularCombos(vm.TipoOperacaoID, vm.CoordenadorOperadorID);

      return View(vm);
    }

    // POST: Operacao/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(OperacaoViewModel model)
    {
      // Campos que vamos preencher manualmente (igual ao Create)
      ModelState.Remove("Coordenador");
      ModelState.Remove("TipoOperacaoNome");

      if (!ModelState.IsValid)
      {
        // Recarregar combos se der erro de validação
        PopularCombos(model.TipoOperacaoID, model.CoordenadorOperadorID);
        return View(model);
      }

      // Buscar operação original para preservar DataHoraCriacao
      var original = _operacaoAppService.GetById(model.ID);
      if (original == null)
        return NotFound();

      // Preencher nome do coordenador a partir do ID
      var coord = _operadorAppService.GetById(model.CoordenadorOperadorID);
      if (coord != null)
        model.Coordenador = coord.Nome;

      // Mapear VM -> entidade
      var entidade = _mapper.Map<Operacao>(model);
      entidade.DataHoraCriacao = original.DataHoraCriacao; // preserva

      // Atualiza a operação
      _operacaoAppService.Update(entidade);

      // Atualizar vínculos OperadorOperacao:
      // 1) remover todos os antigos dessa operação
      var atuais = _operadorOperacaoAppService
          .GetAll()
          .Where(oo => oo.OperacaoID == entidade.ID)
          .ToList();

      foreach (var vinculo in atuais)
      {
        _operadorOperacaoAppService.Remove(vinculo);
      }

      // 2) adicionar os que vieram da tela (sessão + voluntários)
      if (model.OperadoresSelecionados != null)
      {
        foreach (var opSel in model.OperadoresSelecionados)
        {
          var novo = new OperadorOperacao
          {
            OperacaoID = entidade.ID,
            OperadorID = opSel.OperadorID,
            SVG = opSel.SVG
          };

          _operadorOperacaoAppService.Add(novo);
        }
      }

      return RedirectToAction(nameof(Index));
    }

    // GET: Operacao/Delete/5
    public IActionResult Delete(int id)
    {
      var operacao = _operacaoAppService.GetById(id);
      var tipoOperacao = _tipoOperacaoAppService.GetById(operacao.TipoOperacaoID);

      if (operacao == null) return NotFound();

      var vm = _mapper.Map<OperacaoViewModel>(operacao);
      vm.TipoOperacaoNome = tipoOperacao.Nome;
      return View(vm);
    }

    // POST: Operacao/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
      var operacao = _operacaoAppService.GetById(id);
      var operadores = _operadorAppService.PegarOperadoresOperacao(id).ToList();

      foreach (var operadorId in operadores)
      {
        var operadorOperacao = _operadorOperacaoAppService.GetById(operadorId);
        if (operadorOperacao != null)
        {
          _operadorOperacaoAppService.Remove(operadorOperacao);
        }
      }

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
