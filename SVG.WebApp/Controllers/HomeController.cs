using Microsoft.AspNetCore.Mvc;

namespace SVG.WebApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
