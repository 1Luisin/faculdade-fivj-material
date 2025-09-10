//1) Faça uma função que receba um inteiro N por parâmetro e leia N
//números reais informados pelo usuário.
//A função deve retornar a quantidade de números positivos lidos.

//2) Faça uma função que receba um inteiro N por parâmetro e leia N 
//números reais informados pelo usuário.
//A função deve retornar a soma dos números positivos lidos.

//3) Faça uma função que receba um inteiro N por parâmetro e leia N 
//números reais informados pelo usuário.
//A função deve retornar o maior número lido.
internal class Program

{


static void Main(string[] args)
{

int N = Convert.ToInt32(Console.ReadLine()); //recebe a quantidade de N vezes que você quer que retorne a quantidade de números positivos 
double numero; // pega cada número que você escreve
 
for (int contador = 1; contador <= N; contador++ ) //enquanto o contador for menor ou igual ao tanto de vezes que vc quer que retorne, o programa continuará funcionando
{
Console.Write("Número: " + contador + " de " + N + ":");
numero = Convert.ToDouble(Console.ReadLine()); // a cada quantidade, você informará um número real

int qntdepositivos = 1; 

if  (numero > 0){ // se o número for maior que zero, conte os positivos

    qntdepositivos++;
}
}



}

}