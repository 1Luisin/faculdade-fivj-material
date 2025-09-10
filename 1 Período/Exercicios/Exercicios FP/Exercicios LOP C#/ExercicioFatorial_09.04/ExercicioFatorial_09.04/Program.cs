using System.Data;

namespace ExercicioFatorial_09._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Digite um valor inteiro e positivo");
            int E;

            Console.WriteLine();
        }

        static int CalcFatorial(int N, double E)
        {
            N = Convert.ToInt32(Console.ReadLine());
            E = N!;
            Console.WriteLine("O fatorial do número fornecido é:" + N);
            return N;
        }        
    }
}
