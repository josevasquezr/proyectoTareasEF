using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoTareasEF;
using proyectoTareasEF.Models;

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

app.MapGet("/api/Tareas", async ([FromServices] TareasContext dbContext) => {
    return Results.Ok(dbContext.Tareas.Include(p => p.Categoria));
});

app.MapGet("/api/Tarea", async ([FromServices] TareasContext dbContext) => {
    return Results.Ok(dbContext.Tareas.Where(p => p.TareaId == Guid.Parse("c88ff4bc-6a99-48ee-95f5-848fc205ac29")).Include(p => p.Categoria));
});

app.MapPost("/api/Tarea", async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea) => {
    tarea.TareaId = Guid.NewGuid();
    tarea.FechaCreacion = DateTime.Now;

    await dbContext.AddAsync(tarea);
    await dbContext.SaveChangesAsync();
    
    return Results.Ok(tarea);
});

app.MapPut("/api/Tarea/{id}", async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea, [FromRoute] Guid id) => {
    Tarea tareaActual = dbContext.Tareas.Find(id);

    if(tareaActual != null){
        tareaActual.CategoriaId = tarea.CategoriaId;
        tareaActual.Titulo = tarea.Titulo;
        tareaActual.Descripcion = tarea.Descripcion;
        tareaActual.PrioridadTarea = tarea.PrioridadTarea;
        tareaActual.Recordatorio = tarea.Recordatorio;
        tareaActual.FechaHoraRecordatorio = tarea.FechaHoraRecordatorio;

        await dbContext.SaveChangesAsync();

        return Results.Ok(tareaActual);
    }

    return Results.NotFound();
});

app.MapDelete("/api/Tarea/{id}", async ([FromServices] TareasContext dbContext, [FromRoute] Guid id) => {
    Tarea tarea = dbContext.Tareas.Find(id);

    if(tarea != null){
        dbContext.Remove(tarea);
        await dbContext.SaveChangesAsync();

        return Results.Ok(tarea);
    }
    
    return Results.NotFound();
});

app.MapGet("/api/Categorias", async ([FromServices] TareasContext dbContext) => {
    return Results.Ok(dbContext.Categorias.Include(p => p.Tareas));
});

app.MapGet("/api/Categoria/{id}", async ([FromServices] TareasContext dbContext, [FromRouteAttribute] string id) => {
    return Results.Ok(dbContext.Categorias.Where(p => p.CategoriaId == Guid.Parse(id)).Include(p => p.Tareas));
});

app.MapPost("/api/Categoria", async ([FromServices] TareasContext dbContext, [FromBody] Categoria categoria) => {
    categoria.CategoriaId = Guid.NewGuid();

    //await dbContext.Categorias.AddAsync(categoria);
    await dbContext.AddAsync(categoria);
    await dbContext.SaveChangesAsync();

    return Results.Ok(categoria);
});

app.Run();
