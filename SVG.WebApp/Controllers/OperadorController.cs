using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SVG.WebApp.Controllers
{
  public class OperadorController : Controller
  {
    // GET: OperadorController
    public ActionResult Index()
    {
      return View();
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
