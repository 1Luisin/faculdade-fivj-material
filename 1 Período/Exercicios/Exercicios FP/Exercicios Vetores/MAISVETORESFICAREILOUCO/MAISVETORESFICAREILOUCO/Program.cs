using System.Numerics;

namespace MAISVETORESFICAREILOUCO
{
    //FAÇA UM PROCEDIMENTO QUE RECEBA UM VETOR DE NÚMEROS REAIS POR PARAMETRO E INVERTA OS ELEMENTOS DESTE VETOR
    //EXEMPLO: O VETOR [1,2,3,7,6], DEVE TERMINAR DESSA FORMA: [6,7,3,2,1]
    internal class Program
    {

        static void INVERTER(double[] vetor) 
        {

            int valormax;

            for (int i = 0;  i < vetor.Length; i++) 
            {

                if (vetor[i] < valormax)
                 { 
                
                }
            }

        
        }
        static void Main(string[] args)
        {
            double[] vetor = new double[6] { 1, 2, 3, 4, 5, 6 };
            INVERTER(vetor);
        }
    }
}
