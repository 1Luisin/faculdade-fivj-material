using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

class Program 
{

    static void Main(string[]args)
    {
        double altura, peso, imc;
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bem vindo ao programa!\n");
        Console.ResetColor();

        Console.WriteLine("Informe a sua altura:");
        altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o seu peso:");
        peso = Convert.ToDouble(Console.ReadLine());

        imc = peso / (altura * altura);
        Console.Clear();

        Console.WriteLine("Seu IMC é: " + imc + ".");
        Console.WriteLine("Pressione qualquer tecla para fechar o programa");
        Console.ReadKey();

    }



}