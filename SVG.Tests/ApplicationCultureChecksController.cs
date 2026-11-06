using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// Disponível somente no host de testes; não integra a aplicação publicada.
[Route("__culture")]
public sealed class ApplicationCultureChecksController : Controller
{
    [HttpPost]
    public IActionResult Check(decimal valor, DateTime data) => new CultureCheckResult(valor, data, CultureInfo.CurrentCulture.Name);

    private sealed class CultureCheckResult(decimal valor, DateTime data, string actionCulture) : IActionResult
    {
        public Task ExecuteResultAsync(ActionContext context) => context.HttpContext.Response.WriteAsync(
            $"{valor.ToString(CultureInfo.InvariantCulture)}|{valor:N2}|{data:dd/MM/yyyy}|{actionCulture}|{CultureInfo.CurrentCulture.Name}");
    }
}
