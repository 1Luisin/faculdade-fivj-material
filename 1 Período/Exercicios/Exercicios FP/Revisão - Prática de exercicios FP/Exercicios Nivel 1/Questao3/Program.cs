//Faça um programa que leia os três lados de um triângulo, calcule e imprima seu perímetro
internal class Program
{
    private static void Main(string[] args)
    {
    int Base, Lado_1, Lado_2;
    Console.Write("Bem vindo ao calculador do perimetro do triangulo ");
    
    Console.WriteLine("Digite o valor em CM da base:");
    Base = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o valor em CM de um dos lados:");
    Lado_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o valor em CM do outro lado do triângulo:");
    Lado_2 = Convert.ToInt32(Console.ReadLine());
    
    int Calculador = Base + Lado_1 + Lado_2; 

    Console.WriteLine("O valor do perímetro do triangulo é de: {0}", Calculador);    
    Console.ReadLine();
    
    }
}