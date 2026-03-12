using Aula02WebAPI.Models;

namespace Aula02WebAPI.DAOs;

public class ProdutoDAO : IDAO<Produto>
{
    public static void Inserir(Produto obj)
    {
        obj.Id = Guid.NewGuid().ToString();
        objetos.Add(obj);
    }

    public static Produto? ObterPorId(string id) => objetos.FirstOrDefault(x => x.Id == id);
    
    public static void Alterar(Produto obj)
    {
        var idx = objetos.FindIndex(x => x.Id == obj.Id);
        
        if (idx >= 0)
            objetos[idx] = obj;
        else
            objetos.Add(obj);
    }

    public static void Excluir(string id) =>
        objetos.RemoveAll(x => x.Id == id);
    
    public static IReadOnlyList<Produto> ObterTodos() => objetos.AsReadOnly();

    private static readonly List<Produto> objetos = [
        new Produto 
        { 
            Id = "1", 
            Codigo = "123", 
            Descricao = "Coca-cola", 
            Preco = 5.5m
        },
        new Produto 
        { 
            Id = "2", 
            Codigo = "125", 
            Descricao = "Pepsi", 
            Preco = 5m
        },
    ];
}
