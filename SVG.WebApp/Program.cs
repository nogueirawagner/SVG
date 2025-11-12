using SVG.Infra.Context.SQLServer;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


// Lê a connection string do appsettings.json
var cs = builder.Configuration.GetConnectionString("ConnectionLocal");

// Registra o DbContext EF6 como Scoped, passando a connection string
builder.Services.AddScoped<SQLServerContext>(_ => new SQLServerContext(cs));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


// Rotas MVC (controllers)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapRazorPages();

app.Run();
