using System.Net;
using System.Reflection;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SVG.App.Interface;
using SVG.App.Interfaces;
using SVG.App.Services;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.Services;
using SVG.Domain.TiposEstruturados.Planejamento;
using SVG.WebApp.Configurations;
using SVG.WebApp.Controllers;

// Host isolado de testes, apenas em loopback, sem SQLServerContext ou credenciais reais.
public static class PlanejamentoWebChecks
{
    public static async Task Run(bool preview=false)
    {
        var plan=new Planejamento{ID=1,Titulo="Planejamento de teste",Endereco="Endereço fictício",DataPrevista=DateTime.Today,
            HorarioBriefingDOE=TimeSpan.FromHours(4.5),HorarioSaidaDOE=TimeSpan.FromHours(5),
            SecaoID=2,Secao=new Sessao{ID=2,Nome="Seção de teste"},CriadorOperadorID=7,Versao=new byte[]{1,2,3},DataHoraCriacao=DateTime.UtcNow,
            Alvos=new List<PlanejamentoAlvo>{new(){AlvoID=9,Alvo=new Alvo{ID=9,Nome="Pessoa fictícia"}}}};
        XPlanejamentoEntrada? entradaSalva=null;
        int Salvar(object?[]? args){entradaSalva=(XPlanejamentoEntrada)args![0]!;return 1;}
        var op=new Operador{ID=7,Nome="Operador de teste",SessaoID=2};
        var repo=DispatchProxy.Create<IPlanejamentoRepository,RepositoryProxy>();
        ((RepositoryProxy)(object)repo).Handler=(method,args)=>method switch {
            "Obter"=>plan,
            "Listar"=>new List<XPlanejamentoResumo>{new(1,plan.Titulo,plan.DataPrevista,"Rascunho","Seção de teste",plan.Endereco,1)},
            "BuscarAlvos"=>new List<XAlvoResumo>{new(9,"Pessoa fictícia",null,null,1)},
            "ObterAlvo"=>new Alvo{ID=9,Nome="Pessoa fictícia",Planejamentos=new List<PlanejamentoAlvo>{new(){Planejamento=plan,PlanejamentoID=1}}},
            "ObterAnexo"=>new AnexoPlanejamento{ID=1,PlanejamentoID=1,NomeArquivo="video.mp4",TipoMime="video/mp4",Caminho="arquivo-de-teste"},
            "ObterAnexoAlvo"=>new AnexoAlvo{ID=1,AlvoID=9,NomeArquivo="video.mp4",TipoMime="video/mp4",Caminho="arquivo-de-teste"},
            "Salvar"=>Salvar(args),
            _=>null
        };
        var ops=DispatchProxy.Create<IOperadorAppService,RepositoryProxy>();
        ((RepositoryProxy)(object)ops).Handler=(m,a)=>m=="GetById"?op:new List<Operador>{op};
        var cars=DispatchProxy.Create<IViaturaAppService,RepositoryProxy>();
        ((RepositoryProxy)(object)cars).Handler=(m,a)=>new List<Viatura>{new(){ID=3,Prefixo="VTR de teste"}};
        var builder=WebApplication.CreateBuilder(new WebApplicationOptions{ApplicationName=typeof(PlanejamentoController).Assembly.FullName,
            ContentRootPath=Path.GetFullPath("SVG.WebApp"),EnvironmentName="Development"});
        builder.WebHost.UseUrls(preview?"http://127.0.0.1:5189":"http://127.0.0.1:0");
        builder.Logging.ClearProviders();
        builder.Services.AddControllersWithViews(options => options.Filters.Add<ApplicationCultureFilter>()).AddApplicationPart(typeof(PlanejamentoController).Assembly);
        builder.Services.AddControllers().AddApplicationPart(typeof(ApplicationCultureChecksController).Assembly);
        var storage=DispatchProxy.Create<IArmazenamentoAnexos,RepositoryProxy>();
        ((RepositoryProxy)(object)storage).Handler=(method,args)=>method=="Abrir"?new MemoryStream(new byte[24]):null;
        builder.Services.AddSingleton(storage);
        builder.Services.AddSingleton<IGoogleMapsService>(new SVG.Infra.Services.GoogleMapsService(new HttpClient(new HttpClientHandler{AllowAutoRedirect=false})));
        builder.Services.AddSingleton(repo);builder.Services.AddSingleton<IPlanejamentoService,PlanejamentoService>();
        builder.Services.AddSingleton<IPlanejamentoAppService,PlanejamentoAppService>();
        builder.Services.AddSingleton(ops);builder.Services.AddSingleton(cars);
        builder.Services.AddHttpContextAccessor();builder.Services.AddScoped<IUserContext,UserContext>();
        builder.Services.AddAuthentication("Test").AddScheme<AuthenticationSchemeOptions,PlanejamentoTestAuth>("Test",_=>{});
        builder.Services.AddAuthorization();
        await using var app=builder.Build();
        app.Use(async (context,next)=>
        {
            System.Globalization.CultureInfo.CurrentCulture=System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
            await next();
        });
        app.UseStaticFiles();app.UseRouting();app.UseAuthentication();app.UseAuthorization();
        app.MapControllerRoute("default","{controller=Planejamento}/{action=Index}/{id?}");
        await app.StartAsync();
        if(preview){Console.WriteLine("Preview isolado em http://127.0.0.1:5189/Planejamento");await Task.Delay(Timeout.Infinite);return;}
        var url=app.Services.GetRequiredService<IServer>().Features.Get<IServerAddressesFeature>()!.Addresses.Single();
        using var handler=new HttpClientHandler{AllowAutoRedirect=false,CookieContainer=new CookieContainer()};
        using var client=new HttpClient(handler){BaseAddress=new Uri(url)};
        int checks=0;
        void Check(bool ok,string text){if(!ok)throw new Exception(text);checks++;}
        var culture=await client.PostAsync("/__culture",new FormUrlEncodedContent(new Dictionary<string,string>{{"valor","1234.56"},{"data","2026-11-05"}}));
        Check(await culture.Content.ReadAsStringAsync()=="1234.56|1.234,56|05/11/2026|pt-BR|pt-BR","Cultura global não separou conversão de formulário e apresentação.");
        foreach(var path in new[]{"/Planejamento/Anexo/1","/Planejamento/AnexoAlvo/1"})
        {
            using var request=new HttpRequestMessage(HttpMethod.Get,path);
            request.Headers.Range=new System.Net.Http.Headers.RangeHeaderValue(0,7);
            using var response=await client.SendAsync(request);
            Check(response.StatusCode==HttpStatusCode.PartialContent && (await response.Content.ReadAsByteArrayAsync()).Length==8,"Intervalo de vídeo não servido.");
            Check(response.Headers.GetValues("X-Content-Type-Options").Single()=="nosniff","Download sem proteção de MIME.");
            using var anonymous=new HttpRequestMessage(HttpMethod.Get,path);
            anonymous.Headers.Add("X-Test-Anonymous","true");
            using var denied=await client.SendAsync(anonymous);
            Check(denied.StatusCode==HttpStatusCode.Unauthorized,"Download anônimo permitido.");
        }
        foreach(var path in new[]{"/Planejamento","/Planejamento/Criar","/Planejamento/Editar/1","/Planejamento/Detalhes/1","/Planejamento/Alvo/9"})
        {
            var response=await client.GetAsync(path);var body=await response.Content.ReadAsStringAsync();
            Check(response.StatusCode==HttpStatusCode.OK,$"Razor falhou em {path}: {body[..Math.Min(body.Length,400)]}");
            Check(body.Contains("Planejamento") || body.Contains("planejamento"),"Conteúdo não renderizado.");
        }
        var withoutToken=await client.PostAsync("/Planejamento/Salvar",new FormUrlEncodedContent(new Dictionary<string,string>{{"Titulo","Sem token"}}));
        Check(withoutToken.StatusCode==HttpStatusCode.BadRequest,"POST sem antiforgery foi aceito.");
        var editing=await client.GetStringAsync("/Planejamento/Editar/1");
        Check(editing.Contains("value=\"04:30\""),"Horário existente não foi formatado no campo de edição.");
        var html=await client.GetStringAsync("/Planejamento/Criar");
        var token=Regex.Match(html,"name=\"__RequestVerificationToken\"[^>]*value=\"([^\"]+)\"").Groups[1].Value;
        Check(token.Length>0,"Token ausente no formulário.");
        var decoded=WebUtility.HtmlDecode(html);
        foreach(var title in new[]{"1. Informações Preliminares","2. Identificação do Alvo","3. Endereço do Alvo","4. Imagens","5. Quadro de Funções","6. Quadro de Horários","7. Comunicações durante Trajeto","8. APH – Médico","9. Medidas Complementares","10. Resumo das Rotas","11. Resumo das Localizações"})
            Check(decoded.Contains(title),"Tópico do modelo ausente: "+title);
        Check(html.Contains("name=\"Link_Endereco_Alvo\"") && !html.Contains("name=\"LinkGoogleMaps\""),"Nome de campo incorreto.");
        Check(!html.Contains("name=\"Titulo\"") && !html.Contains("name=\"Objetivo\""),"Campos removidos ainda presentes no formulário.");
        var form=new Dictionary<string,string>{{"__RequestVerificationToken",WebUtility.HtmlDecode(token)},{"OrdemServico","OS-42"},{"LocalBriefing","Local fictício"},{"HorarioBriefingDOE","04:30"},{"HorarioSaidaDOE","05:00"},{"HorarioBriefingDP","05:30"},{"Link_Rota_DOE_Unidade_Apoio","https://www.google.com/maps/dir/DOE/APOIO"},{"Link_Localizacao_Hospital_1","https://www.google.com/maps?q=-10,-20"},{"SocorristaAPH1","Pessoa de teste"},{"ResponsavelRelatorio","Operador de teste"},{"MBA","true"},{"MP","true"},{"NumeroMBA","MBA-123"},{"Link_Endereco_Alvo","https://www.google.com/maps/search/?api=1&query=-15.1234567,-48.1234567"},{"Latitude","0"},{"Longitude","0"},{"Alvos[0].Nome","Pessoa fictícia"}};
        var saved=await client.PostAsync("/Planejamento/Salvar",new FormUrlEncodedContent(form));
        Check(saved.StatusCode==HttpStatusCode.Redirect,"Cadastro sem título não redirecionou.");
        Check(entradaSalva is { MBA:true, MP:true, NumeroMBA:"MBA-123", OrdemServico:"OS-42" },"Informações preliminares não chegaram à persistência.");
        Check(entradaSalva?.HorarioBriefingDOE==TimeSpan.FromHours(4.5) && entradaSalva.HorarioSaidaDOE==TimeSpan.FromHours(5) && entradaSalva.HorarioBriefingDP==TimeSpan.FromHours(5.5),"Horários não convertidos.");
        Check(entradaSalva?.Link_Rota_DOE_Unidade_Apoio==form["Link_Rota_DOE_Unidade_Apoio"] && entradaSalva.Link_Localizacao_Hospital_1==form["Link_Localizacao_Hospital_1"] && entradaSalva.SocorristaAPH1=="Pessoa de teste" && entradaSalva.ResponsavelRelatorio=="Operador de teste","Campos do modelo não chegaram à persistência.");
        Check(entradaSalva?.Latitude==-15.1234567m && entradaSalva.Longitude==-48.1234567m,"Coordenadas do navegador não foram substituídas pelas do link.");
        var lookup=await client.PostAsync("/Planejamento/CoordenadasMaps",new FormUrlEncodedContent(new Dictionary<string,string>{{"__RequestVerificationToken",WebUtility.HtmlDecode(token)},{"link",form["Link_Endereco_Alvo"]}}));
        Check(lookup.StatusCode==HttpStatusCode.OK && (await lookup.Content.ReadAsStringAsync()).Contains("-15.1234567"),"Consulta automática falhou.");
        var noToken=await client.PostAsync("/Planejamento/CoordenadasMaps",new FormUrlEncodedContent(new Dictionary<string,string>{{"link",form["Link_Endereco_Alvo"]}}));
        Check(noToken.StatusCode==HttpStatusCode.BadRequest,"Consulta sem antiforgery aceita.");
        form["Link_Endereco_Alvo"]="https://www.google.com/maps?q=100,0";
        var invalid=await client.PostAsync("/Planejamento/Salvar",new FormUrlEncodedContent(form));
        Check(invalid.StatusCode==HttpStatusCode.OK,"Erro de validação não retornou formulário.");
        Check((await invalid.Content.ReadAsStringAsync()).Contains("validation-summary-errors"),"Erro de validação não apresentado.");
        form["ID"]="1";form["Versao"]=Convert.ToBase64String(plan.Versao);form["Link_Endereco_Alvo"]="";
        plan.Latitude=-10;plan.Longitude=-20;
        var legacy=await client.PostAsync("/Planejamento/Salvar",new FormUrlEncodedContent(form));
        Check(legacy.StatusCode==HttpStatusCode.Redirect && entradaSalva?.Latitude==-10 && entradaSalva.Longitude==-20,"Edição apagou coordenadas anteriores ao campo de link.");
        plan.Link_Endereco_Alvo="https://www.google.com/maps?q=-10,-20";
        var cleared=await client.PostAsync("/Planejamento/Salvar",new FormUrlEncodedContent(form));
        Check(cleared.StatusCode==HttpStatusCode.Redirect && entradaSalva?.Latitude==null && entradaSalva?.Longitude==null,"Remover link manteve coordenadas antigas.");
        Console.WriteLine($"Planejamento: {checks} verificações HTTP/Razor passaram (repositório simulado, sem banco).");
        await app.StopAsync();
    }
}

public class PlanejamentoTestAuth(IOptionsMonitor<AuthenticationSchemeOptions> options,ILoggerFactory logger,UrlEncoder encoder)
    : AuthenticationHandler<AuthenticationSchemeOptions>(options,logger,encoder)
{
    protected override Task<AuthenticateResult> HandleAuthenticateAsync() => Task.FromResult(Request.Headers.ContainsKey("X-Test-Anonymous")?AuthenticateResult.NoResult():AuthenticateResult.Success(new AuthenticationTicket(
        new ClaimsPrincipal(new ClaimsIdentity(new[]{new Claim(ClaimTypes.Name,"Teste"),new Claim(ClaimTypes.Role,"Operador"),new Claim("OperadorId","7")},"Test")),"Test")));
}
