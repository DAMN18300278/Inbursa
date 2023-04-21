using CrudBlazor.Server.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MyDbContext>();
var app = builder.Build();
app.MapGet("/", () => "ola");

app.Run();
