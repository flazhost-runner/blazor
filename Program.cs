using app.Components;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

var app = builder.Build();
app.UseStaticFiles();
app.MapGet("/health", () => Results.Json(new { status = "ok" }));
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
