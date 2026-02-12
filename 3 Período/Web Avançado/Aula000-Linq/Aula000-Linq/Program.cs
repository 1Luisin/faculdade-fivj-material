internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = [1,2,3,4,5,6,7,8];

        
        /*foreach(var num in numeros)
        {
            Console.WriteLine(num); //Mostrando todos os itens do array 
        }    
        */

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

    }

}