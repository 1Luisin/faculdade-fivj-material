using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    
    {
    
    int Totalsegundos;
    int Conv_Horas;
    int Conv_Minutos;
    int Conv_Segundos;

    Console.WriteLine("Informe o total de tempo em segundos");
    Totalsegundos = Int32.Parse(Console.ReadLine());

     Conv_Horas = Totalsegundos / 3600;
     Conv_Minutos = Totalsegundos % 60;
     
   

    
   
    
    }
}