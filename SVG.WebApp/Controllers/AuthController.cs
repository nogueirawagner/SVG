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
using SVG.WebApp.Configurations;
using System.Text.RegularExpressions;

namespace SVG.WebApp.Controllers
{
  public class AuthController : Controller
  {
    private readonly IUsuarioAppService _usuarioAppService;
    private readonly IOperadorAppService _operadorAppService;
    private readonly IClaimsFactory _claimsFactory;
    private readonly IUserContext _userContext;

    public AuthController(
      IUsuarioAppService usuarioAppService,
      IClaimsFactory claimsFactory,
      IOperadorAppService operadorAppService,
      IUserContext userContext
      )
    {
      _usuarioAppService = usuarioAppService;
      _claimsFactory = claimsFactory;
      _operadorAppService = operadorAppService;
      _userContext = userContext;
    }

    private void PopularCombos()
    {
      var operadores = _operadorAppService
          .GetAll()
          .OrderBy(o => o.Nome)
          .ToList();

      var usuariosAdmin = PegarUsuariosAdmin();
      operadores.AddRange(usuariosAdmin);

      var operadoresDto = operadores.Select(o => new
      {
        o.ID,
        o.Nome,
        o.NumericaDOE,
        o.Alcunha,
        Matricula = o.Matricula
          .Replace(".", "")
          .Replace("-", ""),
        o.SessaoID,
        EhAdmin = usuariosAdmin.Any(s => s.Matricula == o.Matricula.Replace(".", "").Replace("-", ""))
      }).ToList();

      ViewBag.OperadoresJson = JsonConvert.SerializeObject(operadoresDto);
    }

    [HttpGet]
    public IActionResult Login()
    {
      if (_userContext.IsAuthenticated)
      {
        if (User.IsInRole("Admin"))
          return RedirectToAction("Index", "Operacao");

        if (User.IsInRole("Operador"))
          return RedirectToAction("OperacoesSVGAbertoOperador", "Operacao");
      }
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

      login = login.Replace(".", "").Replace("-", "");
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
            "OperacoesSVGAbertoOperador",
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
    string alcunha,
    int? numericaDOE,
    string senha,
    string senhaConfirmacao)
    {
      login = login?.Replace(".", "").Replace("-", "").Trim();

      // Validação básica
      if (string.IsNullOrWhiteSpace(login))
      {
        ModelState.AddModelError("", "A matrícula é obrigatória.");
        return View();
      }

      if (string.IsNullOrWhiteSpace(senha))
      {
        ModelState.AddModelError("", "A senha é obrigatória.");
        return View();
      }

      // Validação da senha
      if (!Regex.IsMatch(
          senha,
          @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).+$"))
      {
        ModelState.AddModelError(
            "",
            "Senha não atende aos critérios de segurança.");

        return View();
      }

      if (senha != senhaConfirmacao)
      {
        ModelState.AddModelError("", "As senhas não conferem.");
        return View();
      }

      // Verifica se usuário já existe
      var usuarioExistente =
          await _usuarioAppService.ObterPorLoginAsync(login);

      if (usuarioExistente != null)
      {
        ModelState.AddModelError("", "Usuário já existente.");
        return View();
      }

      // Operadores
      var operadores = _operadorAppService
          .GetAll()
          .OrderBy(o => o.Nome)
          .ToList();

      // Administradores
      var admins = PegarUsuariosAdmin();

      // Verifica primeiro se é admin
      var admin = admins.FirstOrDefault(a =>
          !string.IsNullOrWhiteSpace(a.Matricula) &&
          a.Matricula
              .Replace(".", "")
              .Replace("-", "")
              .Trim() == login);

      var ehAdmin = admin != null;

      // Se não for admin, procura na base de operadores
      Operador operador = null;

      if (!ehAdmin)
      {
        operador = operadores.FirstOrDefault(o =>
            !string.IsNullOrWhiteSpace(o.Matricula) &&
            o.Matricula
                .Replace(".", "")
                .Replace("-", "")
                .Trim() == login);

        if (operador == null)
        {
          ModelState.AddModelError(
              "",
              "Matrícula não encontrada entre os operadores.");

          return View();
        }

        /*
         * Numérica e Nome de Guerra são obrigatórios
         * somente para operadores.
         */
        if (string.IsNullOrWhiteSpace(alcunha))
        {
          ModelState.AddModelError(
              "",
              "O nome de guerra é obrigatório.");

          return View();
        }

        if (!numericaDOE.HasValue || numericaDOE.Value <= 0)
        {
          ModelState.AddModelError(
              "",
              "A numérica é obrigatória.");

          return View();
        }
      }

      try
      {
        Usuario usuario;

        if (ehAdmin)
        {
          /*
           * Admin não possui Numérica nem Nome de Guerra.
           */
          usuario = new Usuario
          {
            Login = login,
            Nome = admin.Nome,
            Ativo = true
          };
        }
        else
        {
          /*
           * Atualiza os dados do operador.
           * Caso tenham sido corrigidos na tela,
           * sobrescrevemos os valores atuais.
           */
          operador.Alcunha = alcunha.Trim();
          operador.NumericaDOE = numericaDOE.Value;

          _operadorAppService.Update(operador);

          usuario = new Usuario
          {
            Login = login,
            Nome = operador.Nome,
            Ativo = true,
            Operador = operador
          };
        }

        await _usuarioAppService
            .CriarUsuarioComSenhaAsync(usuario, senha);
      }
      catch (Exception ex)
      {
        ModelState.AddModelError("", ex.Message);
        return View();
      }

      TempData["Mensagem"] =
          "Usuário criado com sucesso. Você já pode entrar no sistema.";

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
