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
BootStrapper.RegisterServices(container);

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.Services.UseSimpleInjector(container);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Rotas MVC (controllers)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllers();

app.MapRazorPages();

container.Verify();

app.Run();
