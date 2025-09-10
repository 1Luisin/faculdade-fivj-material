namespace MaiorNum
{
    internal class Program
    {
        //Faça uma função que receba por paramêtro três números inteiros e retorne o maior número dentre os três passados por parâmetro.
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int NumUser;
            Console.WriteLine("Digite o primeiro número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            num3 = Convert.ToInt32(Console.ReadLine());

            NumUser = RetornoNumero(num1, num2, num3);

        }

        static int RetornoNumero(int num1, int num2, int num3)
        {

            int biggestnumber;

            if (num1 > num2 && num1 > num3)
            {
                biggestnumber = num1;
                Console.WriteLine("O primeiro número é o maior");
                Console.ReadLine();
            }

            else if (num2 > num1 && num2 > num3)
            {
                biggestnumber = num2;
                Console.WriteLine("O segundo número é o maior");
                Console.ReadLine();
            }

            else 
            {
                biggestnumber = num3;
                Console.WriteLine("O terceiro número é o maior");
                Console.ReadLine();
            }

            return biggestnumber; 

        }


    }
}
