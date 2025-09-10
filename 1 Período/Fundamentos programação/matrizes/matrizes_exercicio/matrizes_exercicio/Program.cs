namespace matrizes_exercicio
{
    internal class Program
    {
        //percorrendo matrizes pela diagonal principal
        static void Main(string[] args)
        {

            double[,] matriz = new double[3 /* linha */, 3 /* coluna */] //criando a matriz com linha 3, coluna 3
            {   {1.2,2.2,3.7},
                {4,5,6},
                {4,4,3} //declarando todos os valores da matriz
            };

            for (int i = 0; i < matriz.GetLength(0); i++) // percorrendo a matriz para conseguir printar os números que eu desejo
            {
                Console.WriteLine(matriz[i, i]); //mostrando apenas a coluna principal
            }


        }
    }
}
