using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SVG.App.Interface;
using SVG.Domain.Configurations.Interface;
using SVG.Domain.Interfaces.Services;

namespace SVG.WebApp.Controllers
{
  public class AuthController : Controller
  {
    private readonly IUsuarioService _usuarioAppService;
    private readonly IClaimsFactory _claimsFactory;

    public AuthController(IUsuarioService usuarioAppService, IClaimsFactory claimsFactory)
    {
      _usuarioAppService = usuarioAppService;
      _claimsFactory = claimsFactory;
    }

    [HttpGet]
    public IActionResult Login() => View();

    [HttpPost]
    public async Task<IActionResult> Login(string login, string senha)
    {
      var usuario = await _usuarioAppService.ValidarLogin(login, senha);
      if (usuario == null)
      {
        ModelState.AddModelError("", "Login inválido");
        return View();
      }

      var principal = _claimsFactory.CriarPrincipal(usuario);

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
