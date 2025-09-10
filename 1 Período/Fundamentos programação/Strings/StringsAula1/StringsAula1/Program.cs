namespace StringsAula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra;

            Console.WriteLine("Informe uma palavra");
            palavra = Console.ReadLine();

            for (int i = 0; i < palavra.Length; i++) // percorrendo o vetor / array 
            {
                if (palavra[i] == 0) // botando uma condição para ficar visualmente mais bonita
                    {
                    Console.Write("{0}", palavra[i]);
                    }
                Console.Write("-{0} ", palavra[i]);

            }
            

            Console.WriteLine(Contrario(palavra));
        
            Console.WriteLine("\n--------------------------------------------");

        }


        static void Contrario(string palavra) 
        {
            
            Console.WriteLine("String impressa em ordem inversa ");
            for (int i = palavra.Length - 1; i >= palavra.Length; i--)
            { 
                Console.Write("\n{0}", palavra[i]);
            }

    }
    
    }

}
