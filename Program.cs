using MiniTodo.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("v1/todos", (AppDbContext context) =>
{
    //var todo = new Todo(Guid.NewGuid(), "Ir a academia", false);
    var todos = context.Todos.ToList();
    return Results.Ok(todos);
});

app.Run();
