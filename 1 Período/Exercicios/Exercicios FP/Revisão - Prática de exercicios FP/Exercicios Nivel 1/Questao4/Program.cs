//Faça um programa que leia um número inteiro e imprima o seu antecessor e sucessor.
internal class Program
{
    private static void Main(string[] args)
    {
    
    int NumeroUsuario;
    string Antecessor = "O número que antecede é: ";
    string Sucessor = "O número que sucede é: ";
    Console.WriteLine("Digite qualquer número:");
    NumeroUsuario = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine(Antecessor + (NumeroUsuario -1));
    Console.WriteLine(Sucessor + (NumeroUsuario +1));    
    }
}