namespace MediaPonderadaTurma
{
    internal class Program
    {
        public enum MenuOptions{start = 1, info, end} 
        static private int minimoparapassar = 6; 
        static private int maximo = 10; // variáveis globais, podem ser usadas em qualquer função

        static void Main(string[] args)
        {
            bool appexit = false;

                while (appexit!= true) // não é a variável que é condicionada com o "true" e sim o valor da variável
                                       //se lê "enquanto o valor falso da variavel "appexit" for diferente de verdadeiro, programa rodará 
                    try
                    {
                        {
                            Console.Clear();

                            Console.WriteLine("Bem vindo ao calculador acadêmico");
                            Console.WriteLine("\n1 - Começar\n2 - Sobre\n3 - Sair");
                            int opcaoescolhida;
                            opcaoescolhida = Convert.ToInt32(Console.ReadLine());
                            MenuOptions opcaoconv = (MenuOptions)opcaoescolhida;

                            switch (opcaoconv)
                            {
                                case MenuOptions.start:
                                    int nota1;
                                    int nota2;
                                    
                                    Console.Clear();
                                    Console.WriteLine("Digite sua primeira nota");
                                    
                                    nota1 = Convert.ToInt32(Console.ReadLine());
                                    
                                    if (nota1 > 10)
                                    {
                                    Console.Clear();
                                        Console.WriteLine("Nota inválida, impossível ter uma pontuação acima de 10 em prova.");
                                        Console.WriteLine("\nPressione qualquer botão para tentar novamente . . .");
                                        Console.ReadLine();
                                        break;
                                    }

                                    Console.Clear();

                                    Console.WriteLine("Digite sua segunda nota");
                                    nota2 = Convert.ToInt32(Console.ReadLine());

                                    if (nota2 > 10)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Nota inválida, impossível ter uma pontuação acima de 10 em prova.");
                                        Console.WriteLine("\nPressione qualquer botão para tentar novamente . . .");
                                        Console.ReadLine();
                                        break;
                                    }

                                    Pontuacao(nota1, nota2);
                                    break;

                                case MenuOptions.info:
                                    Console.Clear();
                                    About();
                                    break;

                            case MenuOptions.end:
                                appexit = true;
                            break;
                            
                                   default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Opção inválida!");
                                    Console.ResetColor();
                                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal. . .");
                                    Console.ReadLine();
                                   break;
                            }
                        }
                    }

                    catch (SystemException)
                    {
                        Console.Clear();
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Formato inválido,digite apenas números. Tente novamente");
                        Console.ResetColor();
                        Console.ReadLine();

                    }
   
            
            static void Pontuacao(int nota1, int nota2)
            {
                try
                {

                    int somanotas = nota1 + nota2;
                    switch (somanotas)
                    {
                        case > 10:
                            Console.Clear();
                            Console.WriteLine($"Pontuação inserida inválida!\nOs valores inseridos ultrapassam o valor máximo de pontuação.\nValor máximo: {maximo}");
                            Console.WriteLine("\nPressione qualquer botão para tentar novamente . . .");
                            Console.ReadLine();
                            break;

                        case < 6:
                            Console.Clear();
                            Console.WriteLine($"Você não está apto para passar de período\n Sua nota: {somanotas}\n Minimo para passar: {minimoparapassar}");
                            Console.ReadLine();
                            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal. . .");
                            break;

                        case >= 6:
                            Console.Clear();
                            Console.WriteLine($"Você está apto para passar de período\n Sua nota: {somanotas}\n Minimo para passar: {minimoparapassar}");
                            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal. . .");
                            Console.ReadLine();
                            break;
                    }
                }
                    catch (SystemException)
                {

                    Console.WriteLine("Formato inválido,digite apenas números. Tente novamente");
                    Console.ReadLine();
                }

            }
        
        static void About()
        { 
            Console.WriteLine($"Este programa faz a conta com base nas suas notas e chega ao valor final que diz se você passou ou não." +
            $"\nNota para passar: {minimoparapassar}" 
             +  $"\n Nota máxima: {maximo}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal. . .");
            Console.ReadLine();                    

        }
        

            
        }
    
    }

}
