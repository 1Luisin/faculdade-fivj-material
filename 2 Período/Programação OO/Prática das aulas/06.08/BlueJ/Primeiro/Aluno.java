public class Aluno
{ 
    //Atributos
    String nome;
    int nota;
    
    //METODO
        
        public Aluno(String n, int nt) {
            nome = n;
            nota = nt;
        }
        
        public boolean EstaAprovado(){
        return (nota >= 7);
        }
}

