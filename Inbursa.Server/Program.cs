using CrudBlazor.Server.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddControllers();
builder.Services.AddCors(options =>{
    options.AddPolicy(name: "MyCors", builder => {
        builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
        .AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("MyCors");

app.MapGet("/", () => "ola");
app.MapControllers();

app.Run();
