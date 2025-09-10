internal class Program

{

static void Main(string[] args)
{
double numero1;
double calculo;

Console.WriteLine("Digite um número");
numero1 = Convert.ToDouble(Console.ReadLine());

calculo = RETORNO_CALC(numero1);

Console.WriteLine("O cálculo é: " + calculo);

}

static double RETORNO_CALC(double num1)
{

double num2;
Console.WriteLine("Digite outro número");
num2 = Convert.ToDouble(Console.ReadLine());
double calc;
calc = num1 + num2; 
return calc;

}


}
