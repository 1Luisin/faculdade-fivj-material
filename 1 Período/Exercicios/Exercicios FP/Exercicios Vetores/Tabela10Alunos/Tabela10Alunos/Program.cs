class Program
{
    //Dada um tabela contendo a idade de 10 alunos, faça um algoritmo que calcule o número de alunos com idade superior a média
  
    const int ALUNOS = 3;

    static void Main(string[] args)
    {
        int i;
        double nota, media, soma = 0;

        string[] frase = new string[ALUNOS];
        
        frase [0] = "Digite a primeira nota";
        frase [1] = "Digite a segunda nota";
        frase [2] = "Digite a terceira nota";
        
        for (i = 0; i <= ALUNOS; i++) {
            
            Console.WriteLine(frase[i]);
            nota = Convert.ToInt32(Console.ReadLine());
            soma = soma + nota;
        }

        media = soma / 4;
        
        Console.WriteLine("A média da turma é de : " + media);
    }





}