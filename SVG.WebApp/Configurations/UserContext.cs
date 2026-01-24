using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Security.Claims;

namespace SVG.WebApp.Configurations
{
  public class UserContext : IUserContext
  {
    private readonly IHttpContextAccessor _httpContext;

    public UserContext(IHttpContextAccessor httpContext)
    {
      _httpContext = httpContext;
    }

    private ClaimsPrincipal User =>
        _httpContext.HttpContext?.User;

    // 🔹 Equivalente a User.Identity.Name
    public string UserName =>
        User?.Identity?.IsAuthenticated == true
            ? User.Identity.Name
            : null;

    public bool IsAuthenticated =>
        _httpContext.HttpContext?.User?.Identity?.IsAuthenticated == true;

    public int? OperadorId
    {
      get
      {
        var val = User?.FindFirstValue("OperadorId");
        return int.TryParse(val, out var id) ? id : null;
      }
    }

    public string Matricula =>
        User?.FindFirstValue("Matricula");


    public bool IsOperador =>
        User?.IsInRole("Operador") == true;

    public bool IsAdmin =>
        User?.IsInRole("Admin") == true;
  }
}
