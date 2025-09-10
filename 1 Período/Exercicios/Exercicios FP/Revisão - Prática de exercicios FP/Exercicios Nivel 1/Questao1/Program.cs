internal class Program
{   
    //Faça um programa que lê uma temperatura em graus Celsius e apresenta-a convertida em graus Fahrenheit. A fórmula de conversão: F ← (9*C+160)/5
    private static void Main(string[] args)
    {
        double TemperaturaUsuario;
        double TemperaturaConvertida;
        Console.WriteLine("Digite a temperatura desejada em graus Celsius.");
        TemperaturaUsuario = Convert.ToDouble(Console.ReadLine());
        
        TemperaturaConvertida = (9 * TemperaturaUsuario +160)/5;
        
        Console.WriteLine("Aqui está sua temperatura convertida {0}F", TemperaturaConvertida);
        Console.ReadLine();
        

    }
}