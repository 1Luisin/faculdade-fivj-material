namespace AjudaTaina
{
    // Questão 5) Faça uma função que leia números reais informados pelo usuário enquanto o número lido for negativo. Assim que for lido um número não negativo, a função deve retornar o número lido. Note que esta função não recebe parâmetros. No método Main, use a sua função para ler um número real não negativo.

    internal class Program
    {
        
        static int RetornarNumeroPositivo()
        {
            Console.Write("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero; 
        }
        
        static void Main(string[] args)
        { 
            int numero;     
            numero = RetornarNumeroPositivo();

            if (numero < 0)
            {
                Console.WriteLine("");
                Console.ReadLine();
            }

            else if (numero > 0)
            {
                Console.WriteLine(numero);
                Console.ReadLine(); 
            }
       

        }
    }

    // Questão 5) Faça uma função que leia números reais informados pelo usuário enquanto o número lido for negativo. Assim que for lido um número não negativo, a função deve retornar o número lido. Note que esta função não recebe parâmetros. No método Main, use a sua função para ler um número real não negativo.

    class Program
    {
        static int RetornarNumeroPositivo()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.Write(" ");
            }
            return numero;
        }
        static void Main(string[] args)
        {

            int numero = RetornarNumeroPositivo();
            Console.WriteLine(numero);
            Console.ReadLine();

        }
    }


}
