public class Cachorro {

    private String nome; // atributo
    private int idade; // atributo
    private String raca; // atributo

    public String getNome(){
        return nome;
    }

    public void setNome(String nome){
        this.nome = nome;
    }

    public String getRaca(){
        return raca;
    }

    public void setRaca(String raca){
        this.raca = raca;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
        if(idade <= 0){
            System.out.println("Idade não permitida!");
        }
    }
    public void MensagemFinal(){
        System.out.println("Informações sobre o cachorro:\n" + getIdade() + "\n" + getRaca() + "\n" + getNome());
    }
}
