using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SVG.App.Interface;
using SVG.App.ViewModels;
using SVG.Domain.Entities;

namespace SVG.WebApp.Controllers
{
  public class OperadorController : Controller
  {
    private readonly IMapper _mapper;
    private readonly IOperadorAppService _operadorAppService;

    public OperadorController(
      IOperadorAppService operadorAppService,
      IMapper mapper
      )
    {
      _mapper = mapper;
      _operadorAppService = operadorAppService;
    }
   
    // GET: OperadorController
    public ActionResult List()
    {
      var operadores = _operadorAppService.GetAll().OrderBy(s => s.Nome);
      var opVM = _mapper.Map<IEnumerable<Operador>, IEnumerable<OperadorViewModel>>(operadores);
      return View(opVM);
    }


    // GET: OperadorController
    public ActionResult Index(string search)
    {
      var operadores = _operadorAppService.GetAll().OrderBy(s => s.Nome).ToList();
      
      if (!string.IsNullOrWhiteSpace(search))
        operadores = operadores.Where(o => o.Nome.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();

      ViewData["search"] = search;

      var opVM = _mapper.Map<IEnumerable<Operador>, IEnumerable<OperadorViewModel>>(operadores);
      return View(opVM);
    }

    // GET: OperadorController/Details/5
    public ActionResult Details(int id)
    {
      return View();
    }

    // GET: OperadorController/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: OperadorController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
      try
      {
        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }

    // GET: OperadorController/Edit/5
    public ActionResult Edit(int id)
    {
      return View();
    }

    // POST: OperadorController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
      try
      {
        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }

    // GET: OperadorController/Delete/5
    public ActionResult Delete(int id)
    {
      return View();
    }

    // POST: OperadorController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
      try
      {
        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }
  }
}
