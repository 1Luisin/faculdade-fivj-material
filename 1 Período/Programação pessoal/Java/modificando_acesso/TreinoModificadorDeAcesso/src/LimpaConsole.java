
public class LimpaConsole {
    
    public static void Limpador() {
        try {
            String os = System.getProperty("os.name");
            if (os.contains("Windows")) {
                new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
            } else {
                Runtime.getRuntime().exec("clear");
            }
        } catch (Exception e) {
            // Trate a exceção, se necessário
            e.printStackTrace();
        }
    }
}