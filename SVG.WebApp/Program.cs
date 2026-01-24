using SimpleInjector;
using SimpleInjector.Lifestyles;
using SVG.Infra.Context.SQLServer;
using SVG.IoC;
using SVG.WebApp.AutoMapper;
using SVG.WebApp.Configurations;

var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var container = new Container();
container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
builder.Services.AddSimpleInjector(container, options => options.AddAspNetCore().AddControllerActivation());
var config = AutoMapperConfig.RegisterMappings();
container.RegisterInstance(config.CreateMapper());

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
