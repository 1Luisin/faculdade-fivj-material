using System.Linq.Expressions;

namespace VerificadorIdade
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                int idade;

                Console.WriteLine("Verificador de idade");
                Console.WriteLine("\nDigite sua idade abaixo:");
                idade = int.Parse(Console.ReadLine());

                switch (idade)
                {
                    case <= 10:
                        Console.WriteLine("Você é uma criança");
                        Console.ReadLine();
                        break;

                    case <= 18:
                        Console.WriteLine("Você é um adolescente");
                        Console.ReadLine();
                        break;


                    default:
                        Console.WriteLine("Você é um adulto");
                        Console.ReadLine();
                        break;
                }

            }
            catch (SystemException)
            {
                Console.WriteLine("ERRO");
                Console.ReadLine();
            }



        }

    }
        
        
}


  

