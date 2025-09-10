namespace Prova;

class Program
{
static int Parametro(int N)
    
    {
     N = 500; // número usado como exemplo.
     int numerousuario;

    Console.WriteLine("Informe um número inteiro");
    numerousuario = Convert.ToInt32(Console.ReadLine());

    for (int contador = 1; numerousuario != N; contador++)
    {
            if(numerousuario < 0 )
            {
                Console.Clear();
                Console.WriteLine("Número não inteiro indentificado,Tente novamente com o comando: dotnet run");
                break;
            }

            else if (numerousuario == N)

            {
                Console.Clear();
                Console.WriteLine("Número igual ao valor do parâmetro!Tente novamente com o comando: dotnet run");
                break;
            }

            else
            {
                Console.Clear();
                Console.WriteLine(contador + " número(s) lido(s): " + numerousuario);
                numerousuario = Convert.ToInt32(Console.ReadLine());
            }
    }
            return contad   or;

    }

    static void Main(string[] args)
    {
    }
}