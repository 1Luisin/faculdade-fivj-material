import java.awt.*;
public class Carro {

    private boolean cambioAutom; //3K
    private boolean vidro; // 0K;
    private boolean alarme; // 5K
    private boolean tetoSolar; // 4K
    private boolean kitMulti; //1.8K
    private boolean potenciaMotor; // 1.0 ou acima
    private boolean importado; // 30% com base no preço base
    private Integer custobase;

    public boolean getImportado(){
        if (importado == true) {
            System.out.println("Carro importado");

        }
        else {
            System.out.println("Carro local.");
        }
        return importado;
    }
    public boolean getCambioAutom(){
        if (cambioAutom == true){
             System.out.println("cambio!");
        }
        else if (cambioAutom == false){
            System.out.println("nao cambio");
        }
        return cambioAutom;
    }
    public boolean getVidro(){
        if (vidro == true){
            System.out.println("Vidro automatico!");
        }
        else if (vidro == false){
            System.out.println("Vidro manual!");
        }
        return vidro;
    }
    public boolean getAlarme(){
        if (alarme == true){
            System.out.println("Tem alarme!");
        }
        else if (alarme == false){
            System.out.println("Não tem alarme!");
        }
        return alarme;
    }
    public boolean getTetoSolar(){
        if (tetoSolar == true){
            System.out.println("Tem teto solar!");
        }
        else if (tetoSolar == false){
            System.out.println("Não tem teto solar!");
        }
        return tetoSolar;
    }
    public boolean getKitMulti() {
        if (kitMulti == true){
            System.out.println("Tem kit Multimidia");
        }
        else if (kitMulti == false){
            System.out.println("Não tem kit Multimidia");
        }
        return kitMulti;
    }
    public boolean getPotenciaMotor(){
        if(potenciaMotor == true){
            System.out.println("Potencia motor acima de 1.0");
        }
        else{
            System.out.println("Potencia do motor 1.0");
        }
        return potenciaMotor;
    }
    public void setCustoBase(Integer custobase){
        this.custobase = custobase;
    }
    public void CustoFinal(){
        // aqui tem que ser inserido o custo = 30% importação (boolean) carros 1.0 (-10%)
        if(cambioAutom == true) {
        }
    }
    public void MensagemFinal(){
        System.out.println("Carro final tem:");
    }


}

