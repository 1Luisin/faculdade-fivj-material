import java.lang.Math;

public class Calculador {

    private Double x1,x2,y1,y2;

    public Double getX1() {
        return x1;
    }
    public void setX1(Double x1){
        if (x1 >= 0){
            this.x1 = x1;
        }
        else{
        System.out.println("Número menor que 0!");
        }
    }
    public Double getX2(){
        return x2;
    }
    public void setX2(Double x2){
        if (x2 >= 0){
            this.x2 = x2;
        }
        else{
            System.out.println("Número menor que 0!");
        }
    }
    public Double getY1(){
        return y1;
    }
    public void setY1(Double y1){
        if (y1 >= 0){
            this.y1 = y1;
        }
        else{
            System.out.println("Número menor que 0!");
        }
    }
    public Double getY2(){
        return y2;
    }
    public void setY2(Double y2){
        if (y2 >= 0){
            this.y2 = y2;
        }
        else{
            System.out.println("Número menor que 0!");
        }
    }

    public double Calculadora(){
        double resultado = Math.sqrt((x2 - x1) * (x2 - x1)) + ((y2 - y1)  * (y2 - y1));;
        return resultado;
    }
}
