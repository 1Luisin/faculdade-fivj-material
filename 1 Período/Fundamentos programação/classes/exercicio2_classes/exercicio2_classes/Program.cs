namespace exercicio2_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoopRepeticao loop = new LoopRepeticao();
            
            while(loop.Menu = true) 
            {
                User_info user_info = new User_info();
                Console.WriteLine("Bem vindo ao programa!\nDigite seu peso abaixo.");
                user_info.peso = Console.ReadLine();
                Console.WriteLine("Agora digite sua altura abaixo!");
                user_info.altura = Console.ReadLine();

                Console.WriteLine($"Peso informado = {user_info.peso}\nAltura informada = {user_info.altura}");
                Console.ReadLine();
            }
            
        }
    }
}
