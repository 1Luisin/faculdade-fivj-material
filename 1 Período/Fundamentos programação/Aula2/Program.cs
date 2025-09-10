class Program
{
    static void Main(string[] args)
    {
    
    int idade;
    Console.Write("Informe a sua idade:");
    idade = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Em 2026 você terá " + (idade + 1));
    
    }

//exemplo dado na aula ->

    static void Exemploaula()
    {
        int idade;
        Console.WriteLine("Informe a a sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        //idade é igual o que o usuário escrever, transformado em int

        Console.WriteLine("Em 2026 você terá {0} anos.", idade + 1 );

   
    }

}