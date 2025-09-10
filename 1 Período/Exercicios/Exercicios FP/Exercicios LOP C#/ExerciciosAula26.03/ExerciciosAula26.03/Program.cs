namespace ExerciciosAula26._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe um segundo número");
            int SegundoNumero= Convert.ToInt32(Console.ReadLine());

            if (primeiroNumero > SegundoNumero)
            {
                Console.Clear();
                Console.WriteLine("O primeiro número é o maior, pressione qualquer tecla para continuar");
                Console.ReadLine();
            }

            else if (primeiroNumero > SegundoNumero)
            {
                Console.Clear();
                Console.WriteLine("O segundo número é o maior, pressione qualquer tecla para continuar");
                Console.ReadLine();
            }

            else
            { 
                Console.Clear();
                Console.WriteLine("Os dois números são iguais, pressione qualquer tecla para continuar");
                Console.ReadLine();

            }
        
        }
    }
}