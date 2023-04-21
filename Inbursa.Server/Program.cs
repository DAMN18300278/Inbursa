using CrudBlazor.Server.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "ola");
app.MapControllers();

app.Run();
