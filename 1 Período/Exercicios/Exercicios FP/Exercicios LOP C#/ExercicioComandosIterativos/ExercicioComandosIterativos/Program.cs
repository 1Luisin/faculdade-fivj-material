namespace ExercicioComandosIterativos
{
    internal class Program
    {

        //Programa que imprime todos os números pares no intervalo de 0 a 100
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime todos os números pares no intervalo de 0 a 100");
            int number = 1; // inicialização
            
            while(number <= 100) // condição
            {
               if (number % 2 == 0) 
                {
                    Console.WriteLine(number); //retorno ao usuário
                }
            
             number++; // atualização 
                //number ++ = incremento

            }            

            Console.ReadKey();
        }
    }
}
