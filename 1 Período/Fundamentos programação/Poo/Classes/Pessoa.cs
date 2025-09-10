struct Raça
{
    string? Raça1;
    string? Raça2;
    string? Raça3;
 }
class Pessoa
{
    public int Idade;
    public string? Nome;
    public Raça Raça1;

    // método de apresentação
    public void Apresentacao()
    {
        Console.WriteLine($"Olá, meu nome é: {Nome}");
    }

    public string VerificarIdade()
    {
        return Idade >= 18 ? "Maior de idade" : "Menor de idade";
    }
}


