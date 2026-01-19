using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SVG.App.Interface;
using SVG.App.Interfaces;
using SVG.Domain.Configurations.Interface;
using SVG.Domain.Entities;
using SVG.Domain.Entities.Identity;
using SVG.Infra.Context.SQLServer;
using System.Text.RegularExpressions;

namespace SVG.WebApp.Controllers
{
  public class AuthController : Controller
  {
    private readonly IUsuarioAppService _usuarioAppService;
    private readonly IOperadorAppService _operadorAppService;
    private readonly IClaimsFactory _claimsFactory;

    public AuthController(
      IUsuarioAppService usuarioAppService,
      IClaimsFactory claimsFactory,
      IOperadorAppService operadorAppService)
    {
      _usuarioAppService = usuarioAppService;
      _claimsFactory = claimsFactory;
      _operadorAppService = operadorAppService;
    }

    private void PopularCombos()
    {
      var operadores = _operadorAppService
          .GetAll()
          .OrderBy(o => o.Nome)
          .ToList();

      operadores.AddRange(PegarUsuariosAdmin());

      var operadoresDto = operadores.Select(o => new
      {
        o.ID,
        o.Nome,
        Matricula = o.Matricula
          .Replace(".", "")
          .Replace("-", ""),
        o.SessaoID
      }).ToList();

      ViewBag.OperadoresJson = JsonConvert.SerializeObject(operadoresDto);
    }

    [HttpGet]
    public IActionResult Login()
    {
      PopularCombos();
      return View();
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(string login, string senha)
    {
      if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
      {
        ModelState.AddModelError("", "Informe login e senha.");
        return View();
      }

      // 🔹 normaliza matrícula
      var loginNormalizado = Regex.Replace(login, @"\D", "");

      var normOperadores = _operadorAppService
          .GetAll()
          .OrderBy(o => o.Nome)
          .ToList();
      normOperadores.AddRange(PegarUsuariosAdmin());

      var operador = normOperadores.First(s => s.Matricula.Replace(".", "").Replace("-", "") == login);

      var usuario = await _usuarioAppService.ValidarLogin(loginNormalizado, senha);
      if (usuario == null)
      {
        ModelState.AddModelError("", "Login ou senha inválidos.");
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

      var isOperador = usuario.Roles.Any(r => r.Role.Nome == "Operador");

      // 🔹 Redirecionamento por role
      if (isOperador)
      {
        return RedirectToAction(
            "PegarOperacoesSVGAberto",
            "Operacao"
        );
      }
      else
      {
        // 🔹 Demais perfis
        return RedirectToAction("Index", "Operacao");
      }
    }

    public async Task<IActionResult> Logout()
    {
      await HttpContext.SignOutAsync("Cookies");
      return RedirectToAction("Login");
    }

    [AllowAnonymous]
    public IActionResult CriarUsuario()
    {
      PopularCombos();
      return View();
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CriarUsuario(
     string login,
     string nome,
     string senha,
     string senhaConfirmacao)
    {
      // 🔒 validações básicas
      if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(nome))
      {
        ModelState.AddModelError("", "Login e nome são obrigatórios.");
        return View();
      }

      if (string.IsNullOrWhiteSpace(senha) || senha != senhaConfirmacao)
      {
        if (!Regex.IsMatch(senha, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).+$"))
          ModelState.AddModelError("", "Senha não atende aos critérios de segurança.");

        ModelState.AddModelError("", "As senhas não conferem.");
        return View();
      }

      var normOperadores = _operadorAppService
          .GetAll()
          .OrderBy(o => o.Nome)
          .ToList();

      var admins = PegarUsuariosAdmin();
      normOperadores.AddRange(admins);

      var operador = normOperadores.First(s => s.Matricula.Replace(".", "").Replace("-", "") == login);
      operador.Alcunha = nome;

      if (operador == null)
      {
        ModelState.AddModelError("", "Matrícula não encontrada entre os operadores.");
        return View();
      }

      try
      {
        var usuario = new Usuario();

        if (!admins.Any(a => a.Matricula == login))
        {
          // 🔹 cria usuário
          usuario = new Usuario
          {
            Login = login,
            Nome = nome.Trim(),
            Ativo = true,
            Operador = operador
          };

          _operadorAppService.Update(operador);
        }
        else
        {
          // 🔹 cria usuário
          usuario = new Usuario
          {
            Login = login,
            Nome = nome.Trim(),
            Ativo = true
          };
        }

        await _usuarioAppService.CriarUsuarioComSenhaAsync(usuario, senha);
      }
      catch (Exception ex)
      {
        ModelState.AddModelError("", ex.Message);
        return View();
      }

      TempData["Mensagem"] = "Usuário criado com sucesso. Você já pode entrar no sistema.";
      return RedirectToAction("Login");
    }

    private List<Operador> PegarUsuariosAdmin()
    {
      var usuarios = new List<Operador>
      {
        new Operador
        {
            Matricula = "632368",
            Nome = "Tilia Rumi Okahara",
            SessaoID = 1
        },

        new Operador
        {
            Matricula = "784052",
            Nome = "Patricia Araujo Ribeiro",
            SessaoID = 1
        },

        new Operador
        {
            Matricula = "2352516",
            Nome = "Rebeca Severo Limongi",
            SessaoID = 1
        },

        new Operador
        {
            Matricula = "23256",
            Nome = "Marlucia da Conceição Teixeira",
            SessaoID = 1
        }
      };

      return usuarios;
    }
  }
}
