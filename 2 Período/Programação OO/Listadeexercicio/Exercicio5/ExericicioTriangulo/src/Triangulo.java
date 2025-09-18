public class Triangulo {

    private double lado1;
    private double lado2;
    private double lado3;

    public double getLado1() {
        return lado1;
    }
    public void setLado1(double lado1){
        this.lado1 = lado1;
    }
    public double getLado2(){
        return lado2;
    }
    public void setLado2(double lado2){
        this.lado2 = lado2;
    }
    public double getLado3 (){
        return lado3;
    }
    public void setLado3(double lado3){
        this.lado3 = lado3;
    }
    public double perimetro(){
        return lado1+lado2+lado3;
    }
    public void tipoTriangulo(){
     if(lado1 == lado2 & lado2 == lado3){
         System.out.println("O triângulo é Equilátero");
     }
     else if (lado1 == lado2 & lado2 != lado3 || lado1 == lado3 && lado2 != lado1 && lado2 == lado3 &&  lado1 != lado3){
        System.out.println("O triângulo é Isósceles");
     }
     else if (lado1 != lado2 && lado2 != lado3){
         System.out.println("O triângulo é Equilátero");
     }
     else{
         System.out.println("Número não permitido!");
     }
    }

    public void MensagemFinal(){
        System.out.println("O perimetro do triangulo é de: " + perimetro());
    }
}
