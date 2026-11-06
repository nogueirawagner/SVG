using System.Globalization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SVG.WebApp.Configurations;

// HTML number/datetime-local usa ponto decimal e ISO, independentemente do SO.
public sealed class ApplicationCultureFilter : IAsyncResourceFilter, IAsyncActionFilter, IAsyncResultFilter
{
    private static readonly object ChaveCultura = new();
    public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
    {
        var original=CultureInfo.CurrentCulture;
        context.HttpContext.Items[ChaveCultura]=original;
        try { CultureInfo.CurrentCulture=CultureInfo.InvariantCulture; await next(); }
        finally { CultureInfo.CurrentCulture=original; }
    }

    // A conversão do formulário ocorre antes desta etapa. Preserva a apresentação
    // de datas e números das telas existentes e a cultura usada pela aplicação.
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if(context.HttpContext.Items[ChaveCultura] is CultureInfo original)
            CultureInfo.CurrentCulture=original;
        await next();
    }

    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        if(context.HttpContext.Items[ChaveCultura] is CultureInfo original)
            CultureInfo.CurrentCulture=original;
        await next();
    }
}
