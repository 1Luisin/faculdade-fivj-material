public class Retangulo {
    private double comprimento;
    private double largura;

    public double getComprimento(){ // pessoa consegue ver o atributo
        return comprimento;
    }
    public void SetComprimento(double comprimento){ // pessoa consegue setar um valor
        this.comprimento = comprimento;
    }
    public double getlargura(){
        return largura;
    }
    public void setLargura (double largura){
        this.largura = largura;
    }
    public double area(){
        return comprimento*largura;
    }
    public double perimetro(){
        return comprimento*largura*2;
    }
    public void MensagemFinal(){
        System.out.println("Resultado:\nPerimetro: " + perimetro() + "\nÁrea: " +  area());
    }
}