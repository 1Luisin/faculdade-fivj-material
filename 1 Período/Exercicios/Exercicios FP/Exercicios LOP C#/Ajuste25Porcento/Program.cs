//programa feito para converter o valor proposto pelo usuário em 25%
internal class Program
{
    enum options {console = 1, notebook, pc, phone}
    private static void Main(string[] args)
    {
    
    int UserValue;
    double ConsolePreco = 4259.00;
    double NotebookPreco = 2500.00;
    double ComputadorPreco = 3959.00;
    double PhonePreco = 1399.00;

    double Desconto1 = ConsolePreco - (ConsolePreco / 4); 
    double Desconto2 = NotebookPreco - (NotebookPreco / 4); 
    double Desconto3 = ComputadorPreco - (ComputadorPreco / 4); 
    double Desconto4 = PhonePreco - (PhonePreco / 4); 

    Console.WriteLine("Bem vindo ao software da loja Techware. Aproveite o desconto de 25% em todos os produtos de carnaval!!");    
    Console.WriteLine("\nSe houver interesse, escolha um de nossos produtos");
    Console.WriteLine("\n1 - PS5\n2 - Notebook\n3 - Computador Gamer\n4 - Moto G35");

    UserValue = Convert.ToInt32(Console.ReadLine());
    options UserOption = (options)UserValue;


            if (UserValue == 1)
            {
                Console.Clear();
                Console.WriteLine("O valor do PS5 originalmente é de: R$" + ConsolePreco + ", mas com desconto fica a partir de: R$" + Desconto1);
                Console.ReadLine();            
            }
    
            else if (UserValue == 2)
            { 
                Console.Clear();
                Console.WriteLine("O valor do PS5 originalmente é de: R$" + NotebookPreco + ", mas com desconto fica a partir de: R$" + Desconto2);
                Console.ReadLine();
            }   

            else if (UserValue == 3)
            {
                Console.Clear();
                Console.WriteLine("O valor do PS5 originalmente é de: R$" + ComputadorPreco + ", mas com desconto fica a partir de: R$" + Desconto3);
                Console.ReadLine();            
            }
            else
            {               
                Console.Clear();
                Console.WriteLine("O valor do Moto G34 originalmente é de: R$" + PhonePreco + ", mas com desconto fica a partir de: R$" + Desconto4);
                Console.ReadLine();            
            }
    
    

    }
}