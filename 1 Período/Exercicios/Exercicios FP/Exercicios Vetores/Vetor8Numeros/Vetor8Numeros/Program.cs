namespace Vetor8Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao programa! Pressione ENTER para começar");
            Console.ReadLine();
            int[] vetor = new int[8]; 
            
            for(int i = 0; i < vetor.Length; i++) 
            {
                Console.Clear();
                Console.WriteLine("Digite 8 números!");
                int NumUsuario = Convert.ToInt32(Console.ReadLine());
                vetor[i] = NumUsuario;
            }

            for (int i = 0; i < vetor.Length; i++)
            {

                if (i % 2 == 0) 
                {
                    Console.WriteLine("Vetores pares informados:" + vetor[i]);
                
                }

            }
        }
    }
}
