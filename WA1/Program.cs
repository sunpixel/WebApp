var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseWelcomePage();

//app.MapGet("/", () => "Hell World!");



app.Run();
