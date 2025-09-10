import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {        
        
        Scanner Leitura = new Scanner(System.in);
        LimpaConsole ClearObj = new LimpaConsole();
        
        boolean sair = false;
        
        while(sair != true){
        Pessoa Pessoaobj = new Pessoa();
        System.out.println("Cadastro de usuário!\n");
            System.out.println("1 - Começar\n2 - Sair");
                
                int opcaoUsuario = Leitura.nextInt();
                    switch (opcaoUsuario) {
                      case 1:
                      ClearObj.Limpador();
                      Pessoaobj.RecebeDados();
                      Pessoaobj.RetornaDados();
                     
                      break;
                         
                      case 2:
                        sair = true;
                      break;
                        
                      default:
                            System.out.println("Comando não encontrado!");
                            break;
                    }
            }  
        
    }
}
