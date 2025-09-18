import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Triangulo trianguloObj = new Triangulo();
        System.out.println("Digite o valor da base do triangulo: ");
        trianguloObj.setLado1(scanner.nextDouble());
        System.out.println("Digite o valor de diagonal do triangulo: ");
        trianguloObj.setLado2(scanner.nextDouble());
        System.out.println("Digite o valor da outra diagonal do triangulo: ");
        trianguloObj.setLado3(scanner.nextDouble());
        trianguloObj.MensagemFinal();
        trianguloObj.tipoTriangulo();
    }
}