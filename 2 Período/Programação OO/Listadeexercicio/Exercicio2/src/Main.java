import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner inport = new Scanner(System.in);
        TwoValues TwoValuesObj = new TwoValues();
        System.out.println("Digite o primeiro valor:");
        Integer value1 = inport.nextInt();
        System.out.println("Digite o segundo valor:");
        Integer value2 = inport.nextInt();

        value1 = TwoValuesObj.a;
        value2 = TwoValuesObj.b;

        TwoValuesObj.TwoValuess(value1, value2);

    }
}