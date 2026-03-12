using Aula02WebAPI.DAOs;
using Aula02WebAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/produtos", () => 
    ProdutoDAO.ObterTodos()
);

app.MapGet("/produtos/{id}", (string id) => 
    ProdutoDAO.ObterPorId(id)
);

app.MapPost("/produtos", (Produto obj) => 
    ProdutoDAO.Inserir(obj)
);

app.Run();
