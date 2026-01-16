using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using SVG.Identity.Identity.Context;
using SVG.Infra.Context.SQLServer;
using SVG.IoC;
using SVG.WebApp.AutoMapper;

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

#if DEBUG
 string connectionName = "ConnectionLocal";
#else
        static string connectionName = "ConnectionProduction_Az";
#endif

container.Register(() =>
{
  var optionsBuilder = new DbContextOptionsBuilder<SQLServerContext>();

  optionsBuilder.UseSqlServer(
      builder.Configuration.GetConnectionString(connectionName));

  return optionsBuilder.Options;
}, Lifestyle.Singleton);

// DbContext do Identity (vem da class library)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(connectionName)));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Cookie (rotas padrão do Identity UI)
builder.Services.ConfigureApplicationCookie(opt =>
{
  opt.LoginPath = "/Identity/Account/Login";
  opt.LogoutPath = "/Identity/Account/Logout";
  opt.AccessDeniedPath = "/Identity/Account/AccessDenied";
});


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
    pattern: "{controller=Operacao}/{action=Index}/{id?}");
app.MapControllers();

//app.MapRazorPages();

container.Verify();

app.Run();
