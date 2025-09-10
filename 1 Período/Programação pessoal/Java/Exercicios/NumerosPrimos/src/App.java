import java.util.Scanner;

public class App {
    // Verificador de números divisiveis por 2
    public static void main(String[] args) throws Exception {

        int options;

        do {
            System.out.println("Bem vindo ao programa\n1 - Começar\n2 - Sair");
            Scanner leitura = new Scanner(System.in);

            options = leitura.nextInt();

            switch (options) {
                case 1:
                    System.out.println("Digite qualquer número!");
                    int EntradaUsuario;
                    EntradaUsuario = leitura.nextInt();
                    if (EntradaUsuario % 2 == 0) {
                        System.out.println("Número Dívisivel por 2.");
                    }

                case 2:
                    options = 2;
            }
        } while (options != 2);

    }
}
