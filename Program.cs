using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoTareasEF;

var builder = WebApplication.CreateBuilder(args);

// Conexion a base de datos
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));

builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("TareasDBConexion"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//Confirmacion de creacion de base de datos
app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) => {
    dbContext.Database.EnsureCreated();
    //return Results.Ok($"Base de datos en memoria: { dbContext.Database.IsInMemory() }");
    return Results.Ok($"Base de datos en SqlServer2019: { dbContext.Database.IsSqlServer() }");
});

app.Run();
