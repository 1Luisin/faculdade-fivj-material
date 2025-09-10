using System.Net.Http.Headers;

namespace exercicios3_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoopRepeticao loop = new LoopRepeticao();
            User_info joao = new User_info();

            joao.altura = 1.90;
            joao.peso = 98;

            User_info maria = new User_info();

            maria.altura = 1.50;
            maria.peso = 55;

            while (loop.Menu == true)
            {
                User_info updatejoao = new User_info();
                User_info updatemaria = new User_info();
                updatejoao.altura = 1.78;
                updatemaria.peso = 75;

                Console.WriteLine($"Altura de João = {updatejoao.altura}\nAltura de maria = {maria.altura}\n");
                Console.WriteLine($"Peso de Maria = {updatemaria.peso}\nPeso de João = {joao.peso}\n");

                double media_altura = (maria.altura + updatejoao.altura) / 2;
                double media_peso = (updatemaria.peso + joao.altura) / 2;

                Console.WriteLine($"Média das alturas {media_altura}");

                Console.WriteLine("Reiniciando programa. . .");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }

}