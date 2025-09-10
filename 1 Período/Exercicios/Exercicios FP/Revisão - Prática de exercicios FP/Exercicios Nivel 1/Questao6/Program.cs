//Construa um programa para ler um intervalo de tempo em segundos, converter para horas, minutos e segundos e imprimir o resultado.

internal class Program
{
    private static void Main(string[] args)
    {
        double TempoUsuario;
        double horas, minutos, segundos;
        
        Console.WriteLine("Digite o intervalo de tempo desejado em segundos");
        TempoUsuario = Convert.ToDouble(Console.ReadLine());

        horas =  TempoUsuario / 3600;
        minutos = horas %  TempoUsuario / horas;
        segundos =  minutos % TempoUsuario / minutos;
    
    Console.WriteLine("O valor inserido é equivalente a {0}:{1}:{2}", horas, minutos, segundos);
    }


}