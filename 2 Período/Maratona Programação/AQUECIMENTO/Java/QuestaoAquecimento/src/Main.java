import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int armazenador = 0;
        int valorUsuario = input.nextInt();

        while (valorUsuario  != 0){
            valorUsuario = input.nextInt();
            armazenador = valorUsuario + armazenador;
        }
    System.out.println(armazenador);


    }
}