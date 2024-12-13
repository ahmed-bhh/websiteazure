var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Permet de servir des fichiers statiques depuis wwwroot
app.UseStaticFiles();

// Redirige vers index.html si l'utilisateur visite "/"
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
