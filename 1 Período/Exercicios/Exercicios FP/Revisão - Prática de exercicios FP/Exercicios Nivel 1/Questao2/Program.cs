//Faça um programa que lê um valor de salário mínimo e o salário de um funcionário. O programa deve calcular e imprimir quantos salários mínimos esse funcionário ganha.


internal class Program
{
    const double SALARIO_MINIMO = 1500.00;
    private static void Main(string[] args)
    {
    double SalarioUsuario;
    int SalarioEquivalente;
    Console.WriteLine("Digite abaixo o valor do seu salário:");
    SalarioUsuario = Convert.ToDouble(Console.ReadLine());
    
    SalarioEquivalente = Convert.ToInt32(SalarioUsuario / SALARIO_MINIMO);

        if(SalarioUsuario < SALARIO_MINIMO){
            Console.WriteLine("Seu salário é inferior a 1 salário mínimo");

        }

        else {
            Console.WriteLine("O seu salário equivale a {0} salário(s) mínimo(s).", SalarioEquivalente);
            Console.ReadLine();   
        }
    }
}