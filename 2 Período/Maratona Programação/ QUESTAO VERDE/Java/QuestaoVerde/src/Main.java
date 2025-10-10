import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int numeroUsuario = input.nextInt(); //recebendo numero inicial usuario
        int maiorNum = 0;

        while(numeroUsuario != 0) {

        numeroUsuario = input.nextInt(); // recebendo numero de usuario
        maiorNum = numeroUsuario; 

        }
        System.out.println(maiorNum);
    }
}