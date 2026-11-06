using SimpleInjector;
using SimpleInjector.Lifestyles;
using SVG.Infra.Context.SQLServer;
using SVG.IoC;
using SVG.WebApp.AutoMapper;
using SVG.WebApp.Configurations;

var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews(options => options.Filters.Add<ApplicationCultureFilter>());

var container = new Container();
container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
builder.Services.AddSimpleInjector(container, options => options.AddAspNetCore().AddControllerActivation());
var config = AutoMapperConfig.RegisterMappings();
container.RegisterInstance(config.CreateMapper());

// Fora de wwwroot: os anexos só são servidos por ações autenticadas.
var raizAnexos = builder.Configuration["ArmazenamentoAnexos:Raiz"] ?? builder.Environment.ContentRootPath;
container.RegisterInstance<SVG.Domain.Interfaces.Services.IArmazenamentoAnexos>(
    new SVG.Infra.Storage.ArmazenamentoAnexosLocal(raizAnexos));
container.RegisterInstance<SVG.Domain.Interfaces.Services.IGoogleMapsService>(
    new SVG.Infra.Services.GoogleMapsService(new HttpClient(new HttpClientHandler
    { AllowAutoRedirect = false, UseCookies = false }) { Timeout = TimeSpan.FromSeconds(12) }));
BootStrapper.RegisterServices(container);

builder.Services
    .AddAuthentication("Cookies")
    .AddCookie("Cookies", options =>
    {
      options.LoginPath = "/Auth/Login";
      options.LogoutPath = "/Auth/Logout";
      options.AccessDeniedPath = "/Auth/Login";
      options.ExpireTimeSpan = TimeSpan.FromHours(8);
      options.SlidingExpiration = true;
    });

builder.Services.AddMemoryCache();
builder.Services.AddAuthorization();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IUserContext, UserContext>(); // Específico do projeto Web.

var app = builder.Build();
app.Services.UseSimpleInjector(container);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Rotas MVC (controllers)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}");
app.MapControllers();

//app.MapRazorPages();

container.Verify();

app.Run();
