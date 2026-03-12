using Aula02WebAPI.Models;

namespace Aula02WebAPI.DAOs;

public interface IDAO<T> where T : IModel
{
    static abstract void Inserir(T obj);
    static abstract T? ObterPorId(string id);
    static abstract void Alterar(T obj);
    static abstract void Excluir(string id);
    static abstract IReadOnlyList<T> ObterTodos();
}
