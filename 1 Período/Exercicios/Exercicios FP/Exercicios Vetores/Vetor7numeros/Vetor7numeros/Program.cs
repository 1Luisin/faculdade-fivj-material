using System.Drawing;

namespace Vetor7numeros
{

    //Faça um algoritmo que leia, via teclado, 20 valores do tipo inteiro e determine qual o menor valor existente no vetor e imprima esse valor e seu índice no vetor
    internal class Program
    {
        const int VALORES = 5;
        static void Main(string[] args)
        {
            int[] vetor = new int[VALORES];
            int contador;
            int indicemenor = 0;

            for (contador = 0; contador < vetor.Length; contador++) 
            {
                Console.WriteLine("Inteiro {0} de {1}", contador + 1, vetor.Length);
                vetor[contador] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }            

            for (contador = 1; contador < vetor.Length; contador++) 
            {
                if (vetor[contador] < vetor[indicemenor])
                {
                    indicemenor = contador;
                }
            }
            Console.WriteLine("O menor valor é {0} e está no indice {1}", vetor[indicemenor], indicemenor);
        }
    }
}
