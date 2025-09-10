namespace Questao_1
{
    // Faça um procedimento que receba por parâmetro um número inteiro e escreva “par” se o número recebido por parâmetro for par. Caso contrário, o procedimento deve escrever “ímpar”. No método principal (Main), leia um número inteiro e passe-o por parâmetro para o procedimento criado.
    internal class Program
    {
        static void Main(string[] args)
        {
            int UserNum;
            Console.WriteLine("Digite um número abaixo");
            UserNum = Convert.ToInt32(Console.ReadLine());
            Verificador(UserNum);
            
        }
    static void Verificador(int num)
       
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("O seu número é par");
                Console.ReadLine();
            }

            else if (num % 2 == 1)
            {
                Console.WriteLine("O seu número é ímpar");
                Console.ReadLine();
            }

        }
    
    }
}
