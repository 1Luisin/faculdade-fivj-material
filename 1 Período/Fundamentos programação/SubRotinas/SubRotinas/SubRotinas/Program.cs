namespace SubRotinas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }

        static void Soma() 
        {
            int numero1;
            int numero2;
            Console.WriteLine("Digite o primeiro número");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            numero2 = Convert.ToInt32(Console.ReadLine());
            int soma = numero1 + numero2;
            
            Console.Clear();
            Console.WriteLine(soma);
            Console.ReadLine();

        
        
        }
    
    
    }
}
