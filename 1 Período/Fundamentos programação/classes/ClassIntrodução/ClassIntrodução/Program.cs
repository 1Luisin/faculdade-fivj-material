using System.Security.AccessControl;

namespace ClassIntrodução
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1; // objeto aluno tipo de dado Classe 'aluno'
            aluno1 = new Aluno(); // instanciando a classe
            aluno1.Matricula = 123;
            aluno1.Nome = "Ana";
            aluno1.EnderecoResidencial = new Endereco();
            aluno1.EnderecoResidencial.Logradouro = "Rua da Glória";
             
            Console.WriteLine(aluno1.Nome + " | " + aluno1.EnderecoResidencial.Logradouro + " | " +  aluno1.Matricula);

            Aluno aluno2;
            aluno2 = new Aluno();

            aluno2.Matricula = 234;
            aluno2.Nome = "João";
            aluno2.EnderecoResidencial = new Endereco();
            aluno2.EnderecoResidencial.Logradouro = "Rua Martins";
            
        }
    }
}
