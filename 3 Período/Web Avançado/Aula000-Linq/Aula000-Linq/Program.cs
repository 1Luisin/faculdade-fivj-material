using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = [1,2,3,4,5,6,7,8];

        
        foreach(var num in numeros)
        {
            Console.WriteLine(num); //Mostrando todos os itens do array 
        }    
        

        var pares = from x in numeros where x % 2 == 0 select x;
        
        foreach (var num in pares)
        {
            Console.WriteLine(num); //Mostrando apenas os itens pares do array, de acordo com a consulta LINQ
        }

        var ímpares = from x in numeros where x % 2 != 0 select x;

        foreach(var num in ímpares)
        {
            Console.WriteLine(num); //Mostrando apenas os itens ímpares do array, de acordo com a consulta LINQ
        }
        
        
        
        var paresAoQuadrado = from y in numeros where y % 2 == 0 select y * y;

        foreach(var num in paresAoQuadrado)
        {
            Console.WriteLine(num);
        }
        
        
        int[] numerosDesorganizados= [10, 5, 20, 15, 30, 25];

        var numerosOrganizados = (from x in numerosDesorganizados 
                                 where x > 10 
                                 orderby x descending 
                                 select x).ToArray();
        

        foreach(var num in numerosOrganizados)
        {
            Console.WriteLine(num);
        }  

    }



}