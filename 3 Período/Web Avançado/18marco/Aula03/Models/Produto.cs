using System;

namespace Aula03.Models;

public class Produto
{
    public string Id { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public double Preco { get; set; }

    public void TornarDescricaoMaiusculas()
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception ex)
        {
            throw new MyException(ex);
        }
        
    }
}
