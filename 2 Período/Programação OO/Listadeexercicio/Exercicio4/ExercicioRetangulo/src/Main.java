import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Retangulo RetanguloObj = new Retangulo();
        Scanner scanner = new Scanner(System.in);

        System.out.println("Digite o valor do comprimento do retangulo em centimetros: ");
        RetanguloObj.SetComprimento(scanner.nextDouble());
        System.out.println("Digite o valor da largura do retangulo: em centimetros");
        RetanguloObj.setLargura(scanner.nextDouble());
        RetanguloObj.MensagemFinal();

    }
}