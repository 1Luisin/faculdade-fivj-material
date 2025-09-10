namespace TratamentoExcessao.Pessoal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numerador = 10;
                int denominador = 0;
                int resultado = numerador / denominador;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Erro: Divisão por zero." + ex.Message);
            }
           
            finally
            {
                Console.WriteLine("Fim do programa.");
                Console.ReadLine();
            }

            
        }


    }
}
