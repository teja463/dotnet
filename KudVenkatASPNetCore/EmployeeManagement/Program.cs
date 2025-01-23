var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var serverName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
app.MapGet("/", () => serverName);

app.Run();
