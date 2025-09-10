import java.util.Scanner;

public class PessoaIdade {
        
            
        static int VerificadorIdade(){

        Scanner Leitura = new Scanner(System.in);
        Pessoa PessoaObj = new Pessoa();
            
            
            PessoaObj.idade = Leitura.nextInt();
                
                if (PessoaObj.idade > 150){
                System.out.println("Idade inválida! Insira uma idade válida.");
                VerificadorIdade();
            }
                 else if(PessoaObj.idade < 0){
                System.out.println("Idade inválida! Insira uma idade válida ");
                VerificadorIdade();
            }
        return PessoaObj.idade;
        }
}
