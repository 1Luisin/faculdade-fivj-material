namespace IntroduçãoMatrizes
{
    //exercício 10.06 - Introdução as matrizes

 internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[7, 5]; /*criando uma matriz   0[][][]
                                                                   1[][][]
                                                                   2[][][]
                                                                    0 1 2*/

            for (int i = 0; i < matriz1.GetLength(0); i++) //percorrendo a primeira coluna da matriz (7)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++) //percorrendo a segunda coluna da matriz (5)
                {
                    matriz1[i, j] = Convert.ToInt32(Console.ReadLine()); // lendo os dados do usuário
                }
            }


            for (int i = 0; i < matriz1.GetLength(0); i++) // percorrendo a matriz nvoamente para imprimir os dados que eu preciso
            {
                Console.Write(matriz1[i, 2]); // mostrando a coluna "2" que se refere a coluna 3 que o exercício pede

            }
        }
    }
}
