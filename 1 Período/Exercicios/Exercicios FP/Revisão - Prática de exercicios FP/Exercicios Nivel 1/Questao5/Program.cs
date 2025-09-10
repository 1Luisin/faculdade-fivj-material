//Construa um programa que aplique um desconto de 25% sobre o preço de um produto recebido como entrada e imprima o valor resultante
internal class Program
{
   // enum options {opcao1 = 1, opcao2, opcao3}
    private static void Main(string[] args)
    {
        //options opcoes = (options)Console.ReadLine();
        //int opcaoescolhida;
        
        
        int[] valores = new int[3];
        valores[0] = 32;
        valores[1] = 10;
        valores[2] = 50;
        string produto1, produto2, produto3; 
    
        produto1 = "Jogo";
        produto2 = "Bola";
        produto3 = "Tênis";

        int porcentagem1 = valores[0] / 4;
        int porcentagem2 = valores[1] / 4;
        int porcentagem3 = valores[2] / 4;
        
    Console.WriteLine("Todos os produtos da loja tem 25% de desconto aplicado, por tempo LIMITADO! \n{0}\n{1}\n{2}", produto1, produto2, produto3 + "\nPressione enter para continuar. . .");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine(produto1 + " de " + valores[0] + " para: " + porcentagem1 );
    Console.WriteLine("\n" + produto2 + " de " + valores[1] + " para: " + porcentagem2 );
    Console.WriteLine("\n" + produto3 + " de " + valores[2] + " para: " + porcentagem3 );
    
    }
}