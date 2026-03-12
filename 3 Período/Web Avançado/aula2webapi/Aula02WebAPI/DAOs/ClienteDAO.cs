using Aula02WebAPI.Models;

namespace Aula02WebAPI.DAOs;

public class ClienteDAO : IDAO<Cliente>
{
    public static void Inserir(Cliente obj)
    {
        obj.Id = Guid.NewGuid().ToString();
        objetos.Add(obj);
    }
    
    public static Cliente? ObterPorId(string id) => objetos.FirstOrDefault(x => x.Id == id);
    
    public static void Alterar(Cliente obj)
    {
        var idx = objetos.FindIndex(x => x.Id == obj.Id);

        if (idx >= 0)
            objetos[idx] = obj;
        else
            objetos.Add(obj);
    }

    public static void Excluir(string id) =>
        objetos.RemoveAll(x => x.Id == id);

    public static IReadOnlyList<Cliente> ObterTodos() => objetos.AsReadOnly();

    private static readonly List<Cliente> objetos = [];
}
