
public class Funcionario
{
    //atributos
    private String nome, cargo;
    private double salarioBase, totalVendas;
    private int numeroFilhos, tempoDeEmpresa;
    private boolean ehTrabalhadorNoturno;


    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCargo() {
        return cargo;
    }

    public void setCargo(String cargo) {
        this.cargo = cargo;
    }

    public double getSalarioBase() {
        return salarioBase;
    }

    public void setSalarioBase(double salarioBase) {
        this.salarioBase = salarioBase;
    }

    public double getTotalVendas() {
        return totalVendas;
    }

    public void setTotalVendas(double totalVendas) {
        this.totalVendas = totalVendas;
    }

    public int getNumeroFilhos() {
        return numeroFilhos;
    }

    public void setNumeroFilhos(int numeroFilhos) {
        this.numeroFilhos = (numeroFilhos >= 0)? numeroFilhos: this.numeroFilhos;
    }

    public int getTempoDeEmpresa() {
        return tempoDeEmpresa;
    }

    public void setTempoDeEmpresa(int tempoDeEmpresa) {
        this.tempoDeEmpresa = tempoDeEmpresa;
    }

    public boolean isEhTrabalhadorNoturno() {
        return ehTrabalhadorNoturno;
    }

    public void setEhTrabalhadorNoturno(boolean ehTrabalhadorNoturno) {
        this.ehTrabalhadorNoturno = ehTrabalhadorNoturno;
    }

    //construtores
    public Funcionario(String nome, double salarioBase,
        String cargo, int numeroFilhos,int tempoDeEmpresa,
        boolean ehTrabalhadorNoturno, double totalVendas){
        this.nome = nome;
        this.salarioBase = salarioBase;
        this.cargo = cargo;
        this.numeroFilhos = numeroFilhos;
        this.tempoDeEmpresa = tempoDeEmpresa;
        this.ehTrabalhadorNoturno = ehTrabalhadorNoturno;
        this.totalVendas = totalVendas;
    }

    public double inss() {return (salarioBase * 0.87);};



    public double bonusChefia() {
        return cargo.toUpperCase().equals("CHEFIA")? salarioBase * 0.05: 0;
    }

    public double bonusPorFilho(){
        return numeroFilhos >= 3? 150: numeroFilhos*50;
    }


    public double bonusVendedor(){
        return (cargo.equalsIgnoreCase("VENDEDOR") )? totalVendas * 0.03 : 0;
    }

    public double bonusInsalubridade () {
        return (cargo.equalsIgnoreCase("PROFESSOR") || cargo.equalsIgnoreCase("SEGURANÇA"))? salarioBase * 0.03 : 0;
    }

    public double bonusNoturno() {
        return (ehTrabalhadorNoturno)? salarioBase: 0;

        }

        public double quinquenio() {
        return ((tempoDeEmpresa - (tempoDeEmpresa%5))/5)*500;
        }

    public double salarioLiquido(){

        return this.salarioBase - inss() + bonusPorFilho() +
                bonusVendedor() + bonusChefia() + bonusInsalubridade() + bonusNoturno() + quinquenio();

    }

}
 