using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SVG.App.Interface;

namespace SVG.WebApp.Controllers
{
  public class OperacaoController : Controller
  {
    private readonly IOperacaoAppService _operacaoAppService;

    public OperacaoController(IOperacaoAppService operacaoAppService)
    {
      _operacaoAppService = operacaoAppService;
    }

    // GET: OperacaoController
    public ActionResult Index()
    {
      return View();
    }

    // GET: OperacaoController/Details/5
    public ActionResult Details(int id)
    {
      return View();
    }

    // GET: OperacaoController/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: OperacaoController/Create
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

    // GET: OperacaoController/Edit/5
    public ActionResult Edit(int id)
    {
      return View();
    }

    // POST: OperacaoController/Edit/5
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

    // GET: OperacaoController/Delete/5
    public ActionResult Delete(int id)
    {
      return View();
    }

    // POST: OperacaoController/Delete/5
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
