namespace CriaçãoString
{
    internal class Program
    {

        //Faça um programa que leia duas strings e crie uma terceira que será a concatena~]ao de duas outras strings lidas.
        static void Main(string[] args)
        {
            string carrinho= "Seu carrinho de compras:";
            Console.WriteLine("Digite um item abaixo:");
            string ?User = Console.ReadLine();
            Console.WriteLine($"Digite mais uma item abaixo:");
            string ?User2 = Console.ReadLine();

            Console.WriteLine(carrinho +"\n" + User + "\n" + User2); 


        }
            
        
    
    }
}
