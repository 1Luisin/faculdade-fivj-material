import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int numero1 = input.nextInt();
        int numero2 = input.nextInt();

       if (numero2 == numero1 + 1 || numero2 == numero1 - 1) {
           System.out.println(1);
       }
        else {
            System.out.println(0);
        }
    }
}