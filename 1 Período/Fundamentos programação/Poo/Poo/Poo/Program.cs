namespace Poo
{
    //atributos: "configuração" de uma entidade
    //métodos: Funções dentro de classes, ações com relação aos atributos dentro de classes
    //funções
    //abstração: aspectos essencias de um contexto qualquer
    //objetos: 
   
     class Program
    {
        static void Main()
        {
            Filme filme = new Filme();
            filme.nome = "Ta dando onda";
            filme.data = "09/04/2006";
            filme.estudio = "Estudio Ghibli";
            Filme.Executar();
            Console.ReadLine();
        }
    }

    

}
