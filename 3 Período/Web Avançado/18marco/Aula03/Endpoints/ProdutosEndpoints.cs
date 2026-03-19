using System;
using Aula03.DAOs;
using Aula03.Models;

namespace Aula03.Endpoints;

public static class ProdutosEndpoints
{
    public static void AdicionarEndpointsProdutos(this WebApplication app)
    {
        var grupo = app.MapGroup("/produtos");

        grupo.MapGet("/", () =>
        {
            return Results.Ok(new ProdutoDAO().RetornarTodos());
        });

        grupo.MapGet("/{id}", (string id) =>
        {
            return Results.Ok(new ProdutoDAO().RetornarPorId(id));
        });

        grupo.MapPost("/", (Produto obj) =>
        {
            new ProdutoDAO().Inserir(obj);

            return Results.Created($"/produtos/{obj.Id}", obj);
        });

        grupo.MapPut("/{id}", (string id, Produto obj) =>
        {
            if (obj.Id != id)
                return Results.BadRequest("O identificador na URL não é igual ao identificador do objeto");

            try
            {
                new ProdutoDAO().Alterar(obj);
            }
            catch
            {
                return Results.Problem("Erro na tentativa de retornar produtos");
            }

            return Results.NoContent();
        });

        grupo.MapPatch("/{id}", (string id) =>
        {
            var produto = (new ProdutoDAO().RetornarPorId(id));

            if (produto == null)
                return Results.NotFound();

            try
            {
                produto.TornarDescricaoMaiusculas();
            }
            catch (MyException exM)
            {
                return Results.Problem(exM.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Results.Problem("Erro desconhecido");
            }

            return Results.NoContent();
        });

        grupo.MapDelete("/{id}", (string id) =>
        {
            new ProdutoDAO().Excluir(id);

            return Results.NoContent();
        });
    }
}
