using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoTareasEF;

var builder = WebApplication.CreateBuilder(args);

// Conexion a base de datos
builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//Confirmacion de creacion de base de datos
app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) => {
    if(dbContext.Database.EnsureCreated()){
        return Results.Ok($"Base de datos en memoria: { dbContext.Database.IsInMemory() }");
    }else{
        return Results.Problem("Error al crear base de datos InMemory");
    }
});

app.Run();
