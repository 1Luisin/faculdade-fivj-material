namespace OperacaoEntregaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {

            int usernum1;
            int usernum2;
            char operacao;

            Console.WriteLine("Informe o primeiro número: ");
            usernum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo de operação");
            operacao = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            usernum2 = int.Parse(Console.ReadLine());   

            if (operacao == '+')
            {
                Console.WriteLine($"{usernum1} + {usernum2}\nO resultado desse cálculo é: {usernum1 + usernum2}");
                Console.ReadLine();
            }

            else if (operacao ==  '-') 
            {
            
                Console.Write($"{usernum1} - {usernum2}\nO resultado desse cálculo é: {usernum1 - usernum2}");
                Console.ReadLine();
            }

            else if (operacao == '*')
            {
                Console.WriteLine($"{usernum1} * {usernum2}\nO resultado desse cálculo é: {usernum1 * usernum2}");
                Console.ReadLine();
            }

            else if (operacao == '/')
            {
                Console.WriteLine($"{usernum1} / {usernum2}\nO resultado desse cálculo é: {usernum1 / usernum2}");
                Console.ReadLine();
            }

            else
            { 
                Console.WriteLine("Operação não reconhecida. Fechando programa. . .");
                Console.ReadLine();
            } 
            
            }

            catch (System.FormatException) 
            {

                Console.WriteLine("Formato não aceito. Fechando programa. . .");
                Console.ReadLine();

            }
        }
    }
}
