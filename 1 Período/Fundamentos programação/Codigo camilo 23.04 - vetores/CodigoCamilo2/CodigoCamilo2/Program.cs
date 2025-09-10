namespace CodigoCamilo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[5];

            for (int i = 0;  i < idades.Length; i++)
            {
                Console.WriteLine("Idade {} de {}: ", i + 1 , idades.Length);
                idades[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("\nIdades informadas:");

            for (int i = 0; i < idades.Length; i++)
            {

                Console.WriteLine(idades[i]);
            
            }
        
        }

    }
}
