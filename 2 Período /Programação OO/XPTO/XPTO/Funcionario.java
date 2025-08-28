public class Funcionario
{
    //atributos
    String nome, cargo;
    double salarioBase, totalVendas;
    int numeroFilhos, tempoDeEmpresa;
    boolean ehTrabalhadorNoturno;
    
    //construtores
    public Funcionario(String nome, double salarioBase, String cargo, int numeroFilhos, int tempoDeEmpresa, boolean ehTrabalhadorNoturno, double totalVendas)
    {
        this.nome = nome;
        this.salarioBase = salarioBase;
        this.cargo = cargo;
        this.numeroFilhos = numeroFilhos;
        this.tempoDeEmpresa = tempoDeEmpresa;
        this.ehTrabalhadorNoturno = ehTrabalhadorNoturno;
        this.totalVendas = totalVendas;
    }
    
    public double salarioLiquido(){
         double salarioLiquido;
         salarioLiquido = salarioBase * 0.87;    
        return salarioBase;   
    }
}
    