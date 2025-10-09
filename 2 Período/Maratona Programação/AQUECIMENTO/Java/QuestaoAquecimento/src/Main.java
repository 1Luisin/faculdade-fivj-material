import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

            Scanner num = new Scanner(System.in);
            int soma = 0;

            while(num.nextInt() != 0){
                soma += num.nextInt();
            }
        System.out.println(soma);

    }
}