namespace Aula02WebAPI.Models;

public class Cliente : IModel
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public override string ToString() =>
        $"Cliente [Nome: {Nome}, E-mail: {Email}]";
}
