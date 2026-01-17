using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace SVG.WebApp.Controllers
{
  public class AuthController : Controller
  {
    private readonly IUsuarioService _service;

    public AuthController(IUsuarioService service)
    {
      _service = service;
    }

    [HttpGet]
    public IActionResult Login() => View();

    [HttpPost]
    public async Task<IActionResult> Login(string login, string senha)
    {
      var usuario = await _service.ValidarLogin(login, senha);
      if (usuario == null)
      {
        ModelState.AddModelError("", "Login inválido");
        return View();
      }

      var principal = CriarPrincipal(usuario);

      await HttpContext.SignInAsync("Cookies", principal);

      return RedirectToAction("Index", "Home");
    }

    public async Task<IActionResult> Logout()
    {
      await HttpContext.SignOutAsync("Cookies");
      return RedirectToAction("Login");
    }
  }

}
