using System.Reflection.Metadata;

namespace ProcedimentoEspaçoEmBranco
{
    internal class Program
    {
        //fazer um procedimento para imprimir uma string recebida com parâmetros sem os espaços em branco.

        static bool MenuRepeticao;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite uma palavra");
            string ?str = Console.ReadLine();
            ReceberString(str);
            
        }

        static void ReceberString(string str) {

            for(int i = 0; i < str.Length; i++) {
                
                if (str[i] != ' ')
                {
                    Console.Write(str[i]);
                }

            }
            
            if(str == "") 
            {
                Console.WriteLine("Não foi enviado valores!");
            }
        }
    }
}
