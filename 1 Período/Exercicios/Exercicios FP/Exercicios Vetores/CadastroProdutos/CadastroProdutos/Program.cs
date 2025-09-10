namespace CadastroProdutos
{ 
    internal class Program
    {
         
        static void Main(string[] args)
        {
            String item1 = "Banana";
            String item2 = "Tomate";
            String item3 = "Maçã";
            double[] PrecoMenor = new double[3];

            Console.Clear();
            Console.WriteLine("Realize o cadastro do preço dos seguintes produtos: \n" + item1 + "\n" + item2 + "\n" + item3);
            double[] preco = new double[3];

            for (int i = 0; i < preco.Length; i++)
            {
                Console.WriteLine("Digite o valor do produto:");
                preco[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Preço do produto declarado: " + item1 + " : " + preco[0]);
            Console.WriteLine("Preço do produto declarado: " + item2 + " : " + preco[1]);
            Console.WriteLine("Preço do produto declarado: " + item3 + " : " + preco[2]);
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Digite o valor máximo que você tem e o sistema irá te dizer o seu poder de compra!");
            double valoruser = Convert.ToDouble(Console.ReadLine());
            
            for (int i = 0; i < preco.Length; i++) 
            {
                if (valoruser >= preco[i])
                {
                    PrecoMenor[i] = preco[i];
                        
                        while (PrecoMenor[i] <= valoruser) 
                        {
                        Console.WriteLine("Preços menores :" + PrecoMenor[i]);
                        }

                }

            }
        }

    }
}
