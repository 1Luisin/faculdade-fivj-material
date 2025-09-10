// programa destinado a indicar o número anterior e sucessor do valor indicado pelo usuário

internal class Program
{
    private static void Main(string[] args)
    {

    int ValueUser;
        
    Console.ForegroundColor = ConsoleColor.DarkGreen;    
    Console.WriteLine("Bem vindo ao programa!");
    Console.WriteLine("\nDigite um número para ser retornado o valor sucessor e anterior.");

    ValueUser = Convert.ToInt32(Console.ReadLine());    
    
    int SucFinalValue = ValueUser + 1;
    int AntFinalValue =  ValueUser - 1;
    
    Console.WriteLine("Você deseja saber o número sucessor ou anterior? Digite a opção que você deseja:\n1 - Sucessor\n2 - Anterior");

    int OptionUser;
    OptionUser = Convert.ToInt32(Console.ReadLine());
    
        if(OptionUser == 1)
        {   
            Console.Clear();
            Console.WriteLine("Valor Sucessor = " + SucFinalValue);
        }
    
        else if (OptionUser == 2)
        {
            Console.Clear();
            Console.WriteLine("Valor Antecessor = " + AntFinalValue);
        }    
        
        else 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Comando não indentificado, fechando programa. . .");    
            Console.ResetColor();
        }    
    }


}