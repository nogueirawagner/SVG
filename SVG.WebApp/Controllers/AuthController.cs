using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SVG.App.Interface;
using SVG.App.Interfaces;
using SVG.Domain.Configurations.Interface;
using SVG.Domain.Entities.Identity;
using SVG.Domain.Interfaces.Services;
using System.Security.Claims;

namespace SVG.WebApp.Controllers
{
  public class AuthController : Controller
  {
    private readonly IUsuarioAppService _usuarioAppService;
    private readonly IClaimsFactory _claimsFactory;

    public AuthController(
      IUsuarioAppService usuarioAppService, 
      IClaimsFactory claimsFactory)
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

      var claims = _claimsFactory.CriarPrincipal(usuario);

      await HttpContext.SignInAsync(
           "Cookies",
           claims,
           new AuthenticationProperties
           {
             IsPersistent = true
           });

      return RedirectToAction("Index", "Operacao");
    }

    public async Task<IActionResult> Logout()
    {
      await HttpContext.SignOutAsync("Cookies");
      return RedirectToAction("Login");
    }

    [AllowAnonymous]
    public IActionResult CriarUsuario()
    {
      return View();
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CriarUsuario(string login, string nome)
    {
      if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(nome))
      {
        ModelState.AddModelError("", "Login e nome são obrigatórios.");
        return View();
      }

      var usuario = new Usuario
      {
        Login = login.Trim(),
        Nome = nome.Trim(),
        Ativo = true
      };

      try
      {
        await _usuarioAppService.CriarUsuarioAsync(usuario);
      }
      catch (Exception ex)
      {
        ModelState.AddModelError("", ex.Message);
        return View();
      }

      TempData["Mensagem"] = "Usuário criado com sucesso. Crie sua senha para acessar o sistema.";
      return RedirectToAction("Login");
    }

  }

}
