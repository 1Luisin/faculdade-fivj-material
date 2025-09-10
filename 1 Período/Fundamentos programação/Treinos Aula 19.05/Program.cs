class Program
{

    // FAÇA UM ALGORITMO QUE LEIA, VIA TECLADO, 20 VALORES DO TIPO INTEIRO E DETERMINA QUAL O MENOR VALOR EXISTENTE NO VETOR E IMPRIMA ESSE VALOR E SEU INDICE NO VETOR

    static void Main(string[] args)
    {
        int[] NumUsuario = new int[20];
        Console.WriteLine("Digite 20 números inteiros e o programa dirá qual é o menor valor existente!");
        Console.WriteLine("Pressione ENTER para começar o programa");
        Console.ReadLine();

        for (int contador = 0; contador <= NumUsuario.Length; contador++)
        {
            Console.Clear();
            Console.WriteLine("Digite a idade");
            NumUsuario[contador] = Convert.ToInt32(Console.ReadLine());
        }

        for (int contador = 0; contador <= NumUsuario.Length; contador++ );
        {
            if (NumUsuario[0] > NumUsuario[1]) {
                Console.WriteLine("O primeiro valor informado é menor do que o segundo" + NumUsuario[0] + "" + NumUsuario[1]);
            }


        }


    }



}