namespace CodigoCamilo
{
    internal class Program
    {
        const int NUM_ALUNOS = 5;
        static void Main(string[] args)
        {

            int x;
            int cont = 0;
            double[] nota = new double[NUM_ALUNOS];
            double media;
            double soma = 0;

            for (x = 0; x < NUM_ALUNOS; x++)
            {
                Console.WriteLine("Digite a nota do aluno:");
                    nota[x] = Convert.ToDouble(Console.ReadLine());
                soma += nota[x];
            }

            media = soma / NUM_ALUNOS;
            for (x = 0; x < NUM_ALUNOS; x++)
            {

                if (nota[x] > media)  
                {
                   cont++;

                }
                Console.WriteLine("Média da turma= " + media);
                Console.WriteLine(cont + " notas estão acima da média!");
                Console.ReadLine();
            }            
        }
    }
}
