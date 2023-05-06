namespace src.Models;

class Person{

    public Person()
    {
        this.nome = "template";
        this.idade = 0;
    }

    public Person (string nome, int idade, string cpf){
        this.nome = nome;
        this.idade = idade;
        this.cpf = cpf;
    }
    
    public string nome { get; set;}
    public int idade { get; set; }
    public string cpf { get; set; }
    public bool ativado { get; set; }
}