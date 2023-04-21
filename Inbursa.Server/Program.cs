using CrudBlazor.Server.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddControllers();
builder.Services.AddCors(options =>{
    options.AddDefaultPolicy(builder =>{
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors();

app.MapGet("/", () => "ola");
app.MapControllers();

app.Run();
