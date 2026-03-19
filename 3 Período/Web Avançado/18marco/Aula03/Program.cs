using Aula03;
using Aula03.DAOs;
using Aula03.Endpoints;
using Aula03.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.AdicionarEndpointsProdutos();



app.Run();
