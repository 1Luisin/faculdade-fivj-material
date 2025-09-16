import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        Calculador CalculadoraObj = new Calculador();

        System.out.print("Digite o valor da variavel x1: "); // atribui um valor a x1 e joga pra outra classe
        CalculadoraObj.setX1(input.nextDouble());

        System.out.print("Digite o valor da variavel x2: "); // atribui um valor a x2 e joga pra outra classe
        CalculadoraObj.setX2(input.nextDouble());

        System.out.print("Digite o valor da variavel y1: "); // atribui um valor a y1 e joga pra outra classe
        CalculadoraObj.setY1(input.nextDouble());

        System.out.print("Digite o valor da variavel y2: "); // atribui um valor a y2 e joga pra outra classe
        CalculadoraObj.setY2(input.nextDouble());
        System.out.println("Resultado: " + CalculadoraObj.Calculadora());
    }


}

