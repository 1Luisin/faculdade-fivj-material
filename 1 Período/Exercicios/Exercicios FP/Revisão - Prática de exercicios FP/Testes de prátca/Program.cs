internal class Program
{
    private static void Main(string[] args)
    {
         Console.WriteLine("Digite um valor acima de 0!");
        int valorUser;
        valorUser = Convert.ToInt32(Console.ReadLine());
        
        valorUser = RetornarNumero(valorUser);
            
    }

    static int RetornarNumero(int valorUser)
    {   

       if(valorUser <= 0){ 
          Console.WriteLine("Valor inválido, tente novamente");   
            }                       

        for (int contador = 1; contador <= valorUser; contador++)
        {   

        Console.WriteLine(contador + " de " + valorUser);

        if (contador == valorUser)
        {
            Console.WriteLine("Parou!");
        }
        }
        
        return valorUser;

    }

}