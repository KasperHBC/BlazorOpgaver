using H125Q2BlazorApp.Components;
using H125Q2BlazorApp.Services;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Tilføj authentication og authorization services
builder.Services.AddAuthenticationCore();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, DummyAuthStateProvider>();

// Registrer TaskService som singleton (indeholder kun static data)
builder.Services.AddSingleton<TaskService>();

// Registrer AppState som scoped service
builder.Services.AddScoped<AppState>();

// Registrer ThemeService som scoped service
builder.Services.AddScoped<ThemeService>();

// Registrer ProductService som singleton
builder.Services.AddSingleton<ProductService>();

// Registrer FavoriteService som scoped
builder.Services.AddScoped<FavoriteService>();

// Lyt på port fra environment variable (Railway sætter PORT)
// ASP.NET Core læser automatisk PORT environment variable hvis ASPNETCORE_URLS ikke er sat
var port = Environment.GetEnvironmentVariable("PORT");
if (!string.IsNullOrEmpty(port) && int.TryParse(port, out var portNumber))
{
    builder.WebHost.UseUrls($"http://+:{portNumber}");
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

// Dummy authentication state provider til demonstration
public class DummyAuthStateProvider : AuthenticationStateProvider 
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        // Returner en uautentificeret bruger som standard
        return Task.FromResult(new AuthenticationState(new System.Security.Claims.ClaimsPrincipal()));
    }
}
