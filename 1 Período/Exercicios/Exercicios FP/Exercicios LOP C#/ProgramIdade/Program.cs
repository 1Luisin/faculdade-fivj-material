using System.Net.Http.Headers;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao programa. Digite o nome de cinco pessoas para começarmos");
        
        Console.WriteLine("Usuário 1");
        string UserName1 = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("Usuário 2");
        string UserName2 = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("Usuário 3");
        string UserName3 = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("Usuário 4");
        string UserName4 = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("Usuário 5");
        string UserName5 = Console.ReadLine();

        Console.Clear();
        
        Console.WriteLine("Digite a idade dos usuários respectivos: ");
        Console.WriteLine("Usuário 1");
        int UserAge1 = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
        Console.WriteLine("Usuário 2");
        int UserAge2 = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Usuário 3");
        int UserAge3 = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Usuário 4");
        int UserAge4 = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Usuário 5");
        int UserAge5 = Convert.ToInt32(Console.ReadLine());
        Console.Clear();


    int MediaIdade = (UserAge1 + UserAge2 + UserAge3 + UserAge4 + UserAge5) / 5;

        Console.WriteLine(UserName1 + " " + UserAge1);
        Console.WriteLine(UserName2 + " " + UserAge2);
        Console.WriteLine(UserName3 + " " + UserAge3);
        Console.WriteLine(UserName4 + " " + UserAge4);
        Console.WriteLine(UserName5 + " " + UserAge5);

        Console.WriteLine("\nA média entre as idades fornecidas é de: " + MediaIdade);
        Console.WriteLine("Pressione qualquer tecla para finalizar o programa. . .");
        Console.ReadLine();


    }
}