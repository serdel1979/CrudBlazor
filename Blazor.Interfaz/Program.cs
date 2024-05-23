using Blazor.Interfaz.Components;
using Blazor.Interfaz.Data;
using Blazor.Interfaz.Interfaces;
using Blazor.Interfaz.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var configuraSql = new ConfiguresSQL(builder.Configuration.GetConnectionString("Connection"));
builder.Services.AddSingleton(configuraSql);

builder.Services.AddScoped<IFilmService, FilmService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
