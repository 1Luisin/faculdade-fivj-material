namespace Aula02WebAPI.Models;
public class Produto : IModel
{
    public string Codigo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }

    public override string ToString() =>
        $"Produto [Código: {Codigo}, Descricão: {Descricao}, Preço: {Preco}]";
}
