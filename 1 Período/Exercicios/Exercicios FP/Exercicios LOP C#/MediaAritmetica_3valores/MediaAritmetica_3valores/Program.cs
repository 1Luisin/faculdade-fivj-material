using System.Security.Cryptography;

namespace MediaAritmetica_3valores
{
    internal class Program
    {
        //Faça um procedimento que receba três valores reais e imprima a média aritmética desses valores

        static void Main(string[] args)
        {

            double value1, value2, value3;

            Console.WriteLine("Primeiro valor:");
            value1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Segundo valor:");
            value2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Terceiro valor:");
            value3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            CalculadorMedia(value1, value2, value3);
        }
        static void CalculadorMedia(double value1, double value2, double value3)

        {
            double media = (value1 + value2 + value3) / 3.0;
            Console.WriteLine($"O valor da média entre os 3 valores fornecidos é de {media}");
            Console.ReadLine();
            Console.WriteLine("Concorda??? :)");
            Console.ReadLine();
            Console.WriteLine("SUA OPINIAO NAO IMPORTA!!!!!!!!!!!!!!!!!!!!!!!!!! >:(");
            Console.ReadLine();


        }


    }
}
