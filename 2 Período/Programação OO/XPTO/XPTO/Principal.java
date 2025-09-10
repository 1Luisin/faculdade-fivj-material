public class Principal
{
    public static void main (String[]args){
    
    Funcionario f = new Funcionario("Luis",1000,"Professor",2,23,true,0);
    System.out.println(f.nome);
    f.numeroFilhos = 5;
    System.out.println(f.salarioLiquido());
    
     }
}