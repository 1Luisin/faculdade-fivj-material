import java.util.ArrayList;

public class App {
    public static void main(String[] args) throws Exception {
        
        ArrayList<String> cars = new ArrayList<String>();
        cars.add("Volvo " + " BMW");
        cars.add ("Toyota");
        cars.add("volkswagen");
        cars.add("Ford");

        System.out.println(cars);

        ArrayList<Integer> numeros = new ArrayList<Integer>();
        numeros.add(1);
        numeros.add(2);
        numeros.add(3);
        numeros.add(4);

        System.out.println(numeros);

        ArrayList<Double> NumberFloat = new ArrayList<Double>();

        NumberFloat.add(3.14);
        NumberFloat.add(120.3);

        System.out.println(NumberFloat);

        


    }
}
