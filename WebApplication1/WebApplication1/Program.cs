var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
ernevneroirn
app.MapGet("/", () => "Hello World!");

app.Run();
