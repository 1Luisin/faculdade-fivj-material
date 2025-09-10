namespace exercicioclass
{
    internal class Program
    {
        //Defina uma classe para respresentar as informações de um cartão de crédito. No método principal (Main) da classe Program, instancie dois objetos do tipo da classe criada, atribua valores a cada atributo dos objetos e imprima todos os atributos do segundo do segundo objeto instanciado.
        static void Main(string[] args)
        {
            Info_card informacao_cartao = new Info_card();
            Console.WriteLine("Digite o número do cartão.");
            informacao_cartao.numerocartao = Console.ReadLine();
            Console.WriteLine("Digite o CVV.");
            informacao_cartao.cvv = Console.ReadLine();
            Console.WriteLine("Digite o nome do TITULAR DO CARTÃO.");
            informacao_cartao.nome_titular = Console.ReadLine();

            Console.WriteLine("Confirme as informações:\nNúmero Cartão: " + informacao_cartao.numerocartao + "\nCódigo de Segurança" + informacao_cartao.cvv + "\nNome Titular: " +informacao_cartao.nome_titular);

            Console.ReadLine();
        
            Info_card informacao_cartao2 = new Info_card();
            Console.WriteLine("Digite o número do segundo cartão");
            informacao_cartao2.numerocartao = Console.ReadLine();
            Console.WriteLine("Digite o CVV.");
            informacao_cartao2.cvv = Console.ReadLine();
            Console.WriteLine("Digite o nome do TITULAR DO CARTÃO.");
            informacao_cartao2.nome_titular = Console.ReadLine();

            Console.WriteLine("Confirme as informações:\nNúmero Cartão: " + informacao_cartao.numerocartao + "\nCódigo de Segurança" + informacao_cartao.cvv + "\nNome Titular: " + informacao_cartao.nome_titular);

            Console.ReadLine();

            Console.WriteLine("Certinho!!");
        }

    }
}
