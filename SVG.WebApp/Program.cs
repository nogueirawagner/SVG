using SimpleInjector;
using SimpleInjector.Lifestyles;
using SVG.Infra.Context.SQLServer;
using SVG.IoC;
using SVG.WebApp.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var container = new Container();
container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
builder.Services.AddSimpleInjector(container, options => options.AddAspNetCore().AddControllerActivation());
var config = AutoMapperConfig.RegisterMappings();
container.RegisterInstance(config.CreateMapper());

var app = builder.Build();

var connectionString =
    builder.Configuration.GetConnectionString("ConnectionLocal");

#if DEBUG
var cs = builder.Configuration.GetConnectionString("ConnectionLocal");
# else
var cs =  builder.Configuration.GetConnectionString("ConnectionProduction_Az");
#endif

BootStrapper.RegisterServices(container, cs);


app.Services.UseSimpleInjector(container);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Rotas MVC (controllers)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Operacao}/{action=Create}/{id?}");
app.MapControllers();

app.MapRazorPages();

container.Verify();

app.Run();
