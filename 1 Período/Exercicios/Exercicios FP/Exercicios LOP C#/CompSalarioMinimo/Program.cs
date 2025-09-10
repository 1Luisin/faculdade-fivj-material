internal class Program
{
    private static void Main(string[] args)
    {
     dynamic SalarioMin = 1518;  
     int SalarioUsuario;
    
    Console.WriteLine("Bem vindo ao programa\n");
    Console.WriteLine("Digite seu sálario atual: ");

    SalarioUsuario = Convert.ToInt32(Console.ReadLine());
    
    int CalcFinal = SalarioUsuario / SalarioMin;

    
            if (SalarioUsuario < SalarioMin) 
            {   
                Console.Clear();
                Console.WriteLine("Seu salário é inferior a um salário mínimo, como isso é possível???");
                Console.WriteLine("Pressione qualquer tecla para fechar o programa. . .");
                Console.ReadKey();    
            }
           
            else if(SalarioUsuario == SalarioMin) 
            
            {   
                Console.Clear();
                Console.WriteLine("Seu salário é equivalente a um salário minimo");
                Console.WriteLine("Pressione qualquer tecla para fechar o programa. . .");
                Console.ReadKey();
            }
            
            else
            
            {   
                Console.Clear();
                Console.WriteLine("Seu salário é equivalente a "+ CalcFinal + " salários mínimos");
                Console.WriteLine("Pressione qualquer tecla para finalizar o programa. . .");
                Console.ReadKey();
            }
    

    }
}