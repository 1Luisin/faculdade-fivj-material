using System;
using Aula03.Models;

namespace Aula03.DAOs;

public class ProdutoDAO
{
    public List<Produto> RetornarTodos() => objetos;
    public Produto? RetornarPorId(string id) => objetos.FirstOrDefault(x => x.Id == id);
    public void Inserir(Produto obj)
    {
        obj.Id = Guid.NewGuid().ToString();
        objetos.Add(obj);
    }
    public void Alterar(Produto obj)
    {
        Excluir(obj.Id);
        Inserir(obj);
    }
    public void Excluir(string id) => objetos = objetos.Where(x => x.Id != id).ToList();

    private static List<Produto> objetos = [
        new() { Id = "1", Codigo = "123", Descricao = "Coca-cola", Preco = 5.5 },
        new() { Id = "2", Codigo = "125", Descricao = "Pepsi", Preco = 5.0 },
    ];
}
