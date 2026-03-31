using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SVG.App.Interface;
using SVG.App.Services;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.Enums;
using SVG.Domain.TiposEstruturados.TiposOperador;
using SVG.WebApp.Configurations;

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
    private readonly IUserContext _userContext;

    public OperacaoController(
      IOperacaoAppService operacaoAppService,
      IOperadorAppService operadorAppService,
      ITipoOperacaoAppService tipoOperacaoAppService,
      ISessaoAppService sessaoAppService,
      IOperadorOperacaoAppService operadorOperacaoAppService,
      IMapper mapper,
      IUserContext userContext)
    {
      _operacaoAppService = operacaoAppService;
      _operadorAppService = operadorAppService;
      _tipoOperacaoAppService = tipoOperacaoAppService;
      _sessaoAppService = sessaoAppService;
      _operadorOperacaoAppService = operadorOperacaoAppService;
      _mapper = mapper;
      _userContext = userContext;
    }

    private void PopularCombos(int? tipoOperacaoId = null, int? coordenadorId = null)
    {
      var escala = _operacaoAppService.PegarEscalaPlantao(DateTime.Now).ToList();
      ViewBag.PlantaoHoje = escala.First(s => s.Situacao == XSituacaoPlantao.Atual).Nome;
      ViewBag.PlantaoAmanha = escala.First(s => s.Situacao == XSituacaoPlantao.Proxima).Nome;
      ViewBag.PlantaoFantasma = escala.First(s => s.Situacao == XSituacaoPlantao.Fantasma).Nome;

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

      var escalaHoje = escala.FirstOrDefault(s => s.Situacao == XSituacaoPlantao.Atual);
      ViewBag.Sessoes = sessoes;
      ViewBag.SessaoSelecionadaId = escalaHoje.SecaoID;

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
    [Authorize(Roles = "Admin")]
    public IActionResult Index(string search)
    {
      var escala = _operacaoAppService.PegarEscalaPlantao(DateTime.Now).ToList();
      ViewBag.PlantaoHoje = escala.First(s => s.Situacao == XSituacaoPlantao.Atual).Nome;
      ViewBag.PlantaoAmanha = escala.First(s => s.Situacao == XSituacaoPlantao.Proxima).Nome;
      ViewBag.PlantaoFantasma = escala.First(s => s.Situacao == XSituacaoPlantao.Fantasma).Nome;

      var operacoes = _operacaoAppService.PegarOperacoesRealizadas().ToList();
      if (User.IsInRole("Admin"))
      {
        return View(operacoes);
      }
      else if (User.IsInRole("Operador"))
      {
        return RedirectToAction("Index", "OperacaoOperador");
      }
      else
      {
        return RedirectToAction("Login", "Auth");
      }
    }

    [HttpPost]
    public IActionResult AlterarSVGOperador(int pOperadorID, bool pSVG)
    {
      _operacaoAppService.AlterarSVGOperador(pOperadorID, pSVG);
      return Ok();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EncerrarCalcularSVG(int pOperacaoID)
    {
      var oper = _operacaoAppService.GetById(pOperacaoID);

      var operadores = _operacaoAppService.PegaCandidatoSVG(pOperacaoID).ToList();
      var opSvg = operadores.Select(o => o.OperadorID).ToList();

      var operadoresSVG = CalcularOperdoresSVG(opSvg, oper.QtdVagasRestantes)
        .Select(o => new OperadorSelecionadoVM { OperadorID = o, SVG = true }).ToList();
      SalvarOperadoresOperacao(pOperacaoID, operadoresSVG);

      oper.SvgAberto = false;
      oper.QtdVagasRestantes = 0;
      _operacaoAppService.Update(oper);
      return RedirectToAction("DetalhesOperacao", new { pOperacaoID = pOperacaoID });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EncerrarSVG(int pOperacaoID)
    {
      var oper = _operacaoAppService.GetById(pOperacaoID);
      oper.SvgAberto = false;
      oper.QtdVagasRestantes = 0;

      _operacaoAppService.Update(oper);

      if (_userContext.IsOperador)
        return RedirectToAction("Detalhes", new { id = oper.ID });

      return RedirectToAction("Index");

    }

    [Authorize(Roles = "Admin")]
    // GET: Operacao/Details/5
    public IActionResult DetalhesOperacao(int pOperacaoID)
    {
      var escala = _operacaoAppService.PegarEscalaPlantao(DateTime.Now).ToList();
      ViewBag.PlantaoHoje = escala.First(s => s.Situacao == XSituacaoPlantao.Atual).Nome;
      ViewBag.PlantaoAmanha = escala.First(s => s.Situacao == XSituacaoPlantao.Proxima).Nome;
      ViewBag.PlantaoFantasma = escala.First(s => s.Situacao == XSituacaoPlantao.Fantasma).Nome;

      var op = _operacaoAppService.GetById(pOperacaoID);
      var opVm = _mapper.Map<OperacaoViewModel>(op);

      var operadores = _operacaoAppService.PegarOperadoresOperacaoResumido(pOperacaoID).ToList().OrderBy(s => !s.SVG);
      opVm.OperadoresSelecionados = operadores.Select(o => new OperadorSelecionadoVM
      {
        OperadorID = o.OperadorID,
        SVG = o.SVG,
        Nome = o.Nome,
        Matricula = o.Matricula,
        Sessao = o.Sessao
      }).ToList();
      return View(opVm);
    }

    [Authorize(Roles = "Operador")]
    public IActionResult OperacoesSVGAbertoOperador()
    {
      var escala = _operacaoAppService.PegarEscalaPlantao(DateTime.Now).ToList();
      ViewBag.PlantaoHoje = escala.First(s => s.Situacao == XSituacaoPlantao.Atual).Nome;
      ViewBag.PlantaoAmanha = escala.First(s => s.Situacao == XSituacaoPlantao.Proxima).Nome;
      ViewBag.PlantaoFantasma = escala.First(s => s.Situacao == XSituacaoPlantao.Fantasma).Nome;

      var operador = _userContext.OperadorId.HasValue
         ? _operadorAppService.GetById(_userContext.OperadorId.Value)
         : null;

      var operacoesSVG = _operacaoAppService.PegarOperacoesSVGAbertoOperador(operador.ID).ToList();
      var grupos = operacoesSVG
        .GroupBy(o => o.TipoOperacao)
        .Select(g => new
        {
          TipoOperacao = g.Key,
          Operacoes = g.ToList()
        })
        .ToList();

      ViewBag.GruposTipoOperacao = grupos;
      ViewBag.OperadorId = operador.ID;


      return View(operacoesSVG);
    }

    [Authorize(Roles = "Admin, Operador")]
    public IActionResult OperacoesSVGAberto()
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

      var tipos = _tipoOperacaoAppService
      .GetAll()
      .OrderBy(t => t.Nome)
      .Where(s => s.ID == 3 || s.ID == 4)
      .ToList();

      ViewBag.TiposOperacao = tipos;
      ViewBag.TipoOperacaoID = 1;

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

    [HttpGet]
    public ActionResult ListarOperacoesPorOrdemServico(string pOrdemServico)
    {
      var lista = _operacaoAppService
          .ListarOperacoesPorOrdemServico(pOrdemServico).ToList();

      return Json(lista);
    }


    [HttpGet]
    public ActionResult PegarOperadoresOperacaoResumido(int pOperacaoID)
    {

      var lista = _operacaoAppService
          .PegarOperadoresOperacaoResumido(pOperacaoID).ToList();

      return Json(lista);
    }

    // POST: Operacao/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public void CreateReforcoPlantao(OperacaoViewModel model)
    {
      LimparModelStateCustom();

      if (!ModelState.IsValid)
      {
        PopularCombos(model.TipoOperacaoID, model.CoordenadorOperadorID);
        //return View(model);
      }

      // Exemplo: pegar o nome do coordenador a partir do ID selecionado
      if (model.CoordenadorOperadorID != null)
      {
        var coord = _operadorAppService.GetById(model.CoordenadorOperadorID.Value);
        if (coord != null)
          model.Coordenador = coord.Nome;
      }

      var entidade = _mapper.Map<Operacao>(model);
      entidade.DataHoraCriacao = DateTime.Now;
      entidade.DataHora = model.DataHoraInicio;
      if (entidade.TipoOperacaoID == 3)
        entidade.DataHoraFim = null;

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

      if (!entidade.SvgAberto)
      {
        entidade.QtdVagasRestantes = 0;
      }
      else
      {
        var qtdRestante = model.QtdVagasVoluntarios - operadoresSVG.Count;
        entidade.QtdVagasTotais = model.QtdVagasVoluntarios;
        entidade.QtdVagasRestantes = qtdRestante < 0 ? 0 : qtdRestante;
        entidade.SvgAberto = qtdRestante > 0 ? true : false;
      }

      _operacaoAppService.Add(entidade);

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

    private void LimparModelStateCustom()
    {
      // Simples
      ModelState.Remove("Coordenador");
      ModelState.Remove("TipoOperacaoNome");
      ModelState.Remove("QtdVagasRestantes");

      // Coleção OperadoresSelecionados
      var props = new[]
      {
        "Nome",
        "Matricula",
        "Telefone",
        "Sessao"
    };

      var keysParaRemover = ModelState.Keys
          .Where(k =>
              k.StartsWith("OperadoresSelecionados[", StringComparison.OrdinalIgnoreCase) &&
              props.Any(p => k.EndsWith("." + p, StringComparison.OrdinalIgnoreCase)))
          .ToList();

      foreach (var key in keysParaRemover)
      {
        ModelState.Remove(key);
      }
    }

    // POST: Operacao/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OperacaoViewModel model)
    {
      LimparModelStateCustom();

      if (!ModelState.IsValid)
      {
        PopularCombos(model.TipoOperacaoID, model.CoordenadorOperadorID);
        return View(model);
      }

      // Exemplo: pegar o nome do coordenador a partir do ID selecionado
      if (model.CoordenadorOperadorID != null)
      {
        var coord = _operadorAppService.GetById(model.CoordenadorOperadorID.Value);
        if (coord != null)
          model.Coordenador = coord.Nome;
      }


      var entidade = _mapper.Map<Operacao>(model);
      entidade.DataHoraCriacao = DateTime.Now;
      entidade.OrdemServico = string.Concat("OS ", model.OrdemServico);
      entidade.DataHoraInicio = null;
      entidade.DataHoraFim = null;

      var opSvg = model.OperadoresSelecionados.Where(s => s.SVG).Select(x => x.OperadorID).ToList();
      var operadoresSVG = CalcularOperdoresSVG(opSvg, model.QtdVagasRestantes);

      var operadoresOperacao = model.OperadoresSelecionados.Where(s => !s.SVG).ToList();
      operadoresOperacao.AddRange(operadoresSVG.Select(id => new OperadorSelecionadoVM
      {
        OperadorID = id,
        SVG = true
      }));

      _operacaoAppService.Add(entidade);

      if (!entidade.SvgAberto)
      {
        entidade.QtdVagasRestantes = 0;
      }
      else
      {
        var qtdRestante = model.QtdVagasVoluntarios - operadoresSVG.Count;
        entidade.QtdVagasTotais = model.QtdVagasVoluntarios;
        entidade.QtdVagasRestantes = qtdRestante < 0 ? 0 : qtdRestante;
        entidade.SvgAberto = qtdRestante > 0 ? true : false;
      }


      SalvarOperadoresOperacao(entidade.ID, operadoresOperacao);

      return RedirectToAction(nameof(Index));
    }

    private void SalvarOperadoresOperacao(int pOperacaoID, List<OperadorSelecionadoVM> operadoresOperacao)
    {
      foreach (var op in operadoresOperacao)
      {
        var operadorOperacao = new OperadorOperacao
        {
          OperacaoID = pOperacaoID,
          OperadorID = op.OperadorID,
          SVG = op.SVG
        };
        _operadorOperacaoAppService.Add(operadorOperacao);
      }
    }

    private List<int> CalcularOperdoresSVG(List<int> pOperadoresID, int pQtdVagas)
    {
      var opSvg = pOperadoresID;
      var dataBase = DateTime.Now.AddMonths(-1); // 30 dias.

      var operadoresContemplados = new List<int>();
      if (opSvg.Count > 0)
      {
        if (opSvg.Count > pQtdVagas)
        {
          if (pQtdVagas == 0)
            pQtdVagas = opSvg.Count;

          operadoresContemplados = _operacaoAppService.PegarOperadoresSVG(opSvg.ToArray(), dataBase, pQtdVagas).ToList();
        }
        else
          operadoresContemplados = opSvg;
      }

      return operadoresContemplados;
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

    private OperacaoViewModel MontarViewModelEdicao(int pOperacaoID)
    {
      var operacao = _operacaoAppService.GetById(pOperacaoID);
      if (operacao == null) return null;

      var vm = _mapper.Map<OperacaoViewModel>(operacao);

      // remove prefixo "OS " para a tela
      vm.OrdemServico = (operacao.OrdemServico ?? string.Empty)
          .Replace("OS ", "", StringComparison.OrdinalIgnoreCase)
          .Trim();

      // Coordenador -> achar por nome
      var coord = _operadorAppService
          .GetAll()
          .FirstOrDefault(o => o.Nome == operacao.Coordenador);

      if (coord != null)
        vm.CoordenadorOperadorID = coord.ID;

      vm.QtdVagasVoluntarios = operacao.QtdVagasTotais;

      // Usa o mesmo serviço do Detalhes para carregar operadores
      var detalhes = _operacaoAppService.PegarDetalhesOperacao(pOperacaoID).ToList();

      vm.OperadoresSelecionados = detalhes
          .Select(d => new OperadorSelecionadoVM
          {
            OperadorID = d.OperadorID,
            Nome = d.NomeOperador,
            Matricula = d.Matricula,
            Sessao = d.Sessao,
            SVG = d.SVG
          })
          .ToList();

      return vm;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult EditarOperacao(int pOperacaoID)
    {
      var operacao = _operacaoAppService.GetById(pOperacaoID);
      if (operacao == null)
        return NotFound();

      // proteção extra
      if (operacao.TipoOperacaoID == 3 || operacao.TipoOperacaoID == 4)
        return RedirectToAction(nameof(EditarOperacaoSODelta), new { pOperacaoID });

      var vm = MontarViewModelEdicao(pOperacaoID);
      PopularCombos(vm.TipoOperacaoID, vm.CoordenadorOperadorID);

      return View(vm);
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult EditarOperacaoSODelta(int pOperacaoID)
    {
      var operacao = _operacaoAppService.GetById(pOperacaoID);
      if (operacao == null)
        return NotFound();

      // proteção extra
      if (operacao.TipoOperacaoID != 3 && operacao.TipoOperacaoID != 4)
        return RedirectToAction(nameof(EditarOperacao), new { pOperacaoID });

      var vm = MontarViewModelEdicao(pOperacaoID);

      PopularCombos(vm.TipoOperacaoID, vm.CoordenadorOperadorID);

      var tipos = _tipoOperacaoAppService
          .GetAll()
          .OrderBy(t => t.Nome)
          .Where(t => t.ID == 3 || t.ID == 4)
          .ToList();

      ViewBag.TiposOperacao = tipos;
      ViewBag.TipoOperacaoID = vm.TipoOperacaoID;

      return View(vm);
    }

    private void AtualizarOperadoresOperacao(int operacaoId, List<OperadorSelecionadoVM> operadores)
    {
      var atuais = _operadorOperacaoAppService
          .GetAll()
          .Where(oo => oo.OperacaoID == operacaoId)
          .ToList();

      foreach (var vinculo in atuais)
        _operadorOperacaoAppService.Remove(vinculo);

      if (operadores == null || !operadores.Any())
        return;

      foreach (var op in operadores)
      {
        _operadorOperacaoAppService.Add(new OperadorOperacao
        {
          OperacaoID = operacaoId,
          OperadorID = op.OperadorID,
          SVG = op.SVG
        });
      }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin")]
    public IActionResult EditarOperacao(OperacaoViewModel model)
    {
      LimparModelStateCustom();

      if (!ModelState.IsValid)
      {
        PopularCombos(model.TipoOperacaoID, model.CoordenadorOperadorID);
        return View(model);
      }

      var original = _operacaoAppService.GetById(model.ID);
      if (original == null)
        return NotFound();

      // Exemplo: pegar o nome do coordenador a partir do ID selecionado
      if (model.CoordenadorOperadorID != null)
      {
        var coord = _operadorAppService.GetById(model.CoordenadorOperadorID.Value);
        if (coord != null)
          model.Coordenador = coord.Nome;
      }


      original.OrdemServico = string.Concat("OS ", model.OrdemServico);
      original.DataHoraInicio = null;
      original.DataHoraFim = null;
      original.SvgAberto = model.SvgAberto;

      var opSvg = model.OperadoresSelecionados?
          .Where(s => s.SVG)
          .Select(x => x.OperadorID)
          .ToList() ?? new List<int>();

      var operadoresSVG = CalcularOperdoresSVG(opSvg, model.QtdVagasVoluntarios);

      var operadoresOperacao = model.OperadoresSelecionados?
          .Where(s => !s.SVG)
          .ToList() ?? new List<OperadorSelecionadoVM>();

      operadoresOperacao.AddRange(
          operadoresSVG
              .Where(id => !operadoresOperacao.Any(o => o.OperadorID == id))
              .Select(id => new OperadorSelecionadoVM
              {
                OperadorID = id,
                SVG = true
              }));

      if (!original.SvgAberto)
      {
        original.QtdVagasRestantes = 0;
      }
      else
      {
        var qtdRestante = model.QtdVagasVoluntarios - operadoresSVG.Count;
        original.QtdVagasTotais = model.QtdVagasVoluntarios;
        original.QtdVagasRestantes = qtdRestante < 0 ? 0 : qtdRestante;
        original.SvgAberto = qtdRestante > 0;
      }

      _operacaoAppService.Update(original);
      AtualizarOperadoresOperacao(original.ID, operadoresOperacao);

      return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin")]
    public IActionResult EditarOperacaoSODelta(OperacaoViewModel model)
    {
      LimparModelStateCustom();

      if (!ModelState.IsValid)
      {
        PopularCombos(model.TipoOperacaoID, model.CoordenadorOperadorID);

        var tipos = _tipoOperacaoAppService
            .GetAll()
            .OrderBy(t => t.Nome)
            .Where(t => t.ID == 3 || t.ID == 4)
            .ToList();

        ViewBag.TiposOperacao = tipos;
        return View(model);
      }

      var original = _operacaoAppService.GetById(model.ID);
      if (original == null)
        return NotFound();

      // Exemplo: pegar o nome do coordenador a partir do ID selecionado
      if (model.CoordenadorOperadorID != null)
      {
        var coord = _operadorAppService.GetById(model.CoordenadorOperadorID.Value);
        if (coord != null)
          model.Coordenador = coord.Nome;
      }

      original.OrdemServico = string.Concat("OS ", model.OrdemServico);
      original.DataHoraInicio = model.DataHoraInicio;
      original.DataHoraFim = model.DataHoraFim;
      original.SvgAberto = model.SvgAberto;

      if (original.TipoOperacaoID == 3)
        original.DataHoraFim = null;

      var opSvg = model.OperadoresSelecionados?
          .Where(s => s.SVG)
          .Select(x => x.OperadorID)
          .ToList() ?? new List<int>();

      var dataBase = DateTime.Now.AddMonths(-1);

      var operadoresContemplados = new List<int>();
      if (opSvg.Count > 0)
      {
        if (opSvg.Count > model.QtdVagasVoluntarios)
        {
          if (model.QtdVagasVoluntarios == 0)
            model.QtdVagasVoluntarios = opSvg.Count;

          operadoresContemplados = _operacaoAppService
              .PegarOperadoresSVG(opSvg.ToArray(), dataBase, model.QtdVagasVoluntarios)
              .ToList();
        }
        else
        {
          operadoresContemplados = opSvg;
        }
      }

      var operadoresOperacao = model.OperadoresSelecionados?
          .Where(s => !s.SVG)
          .ToList() ?? new List<OperadorSelecionadoVM>();

      var operadoresSVG = opSvg.Where(id => operadoresContemplados.Contains(id)).ToList();

      operadoresOperacao.AddRange(
          operadoresSVG
              .Where(id => !operadoresOperacao.Any(o => o.OperadorID == id))
              .Select(id => new OperadorSelecionadoVM
              {
                OperadorID = id,
                SVG = true
              }));

      if (!original.SvgAberto)
      {
        original.QtdVagasRestantes = 0;
      }
      else
      {
        var qtdRestante = model.QtdVagasVoluntarios - operadoresSVG.Count;
        original.QtdVagasTotais = model.QtdVagasVoluntarios;
        original.QtdVagasRestantes = qtdRestante < 0 ? 0 : qtdRestante;
        original.SvgAberto = qtdRestante > 0;
      }

      _operacaoAppService.Update(original);
      AtualizarOperadoresOperacao(original.ID, operadoresOperacao);

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
