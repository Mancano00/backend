using Models;
public class Program
{
    public static void Main()
{
    /*
    //instanciando objeto sem método construtor
    Pessoa pessoa1 = new Pessoa();
    pessoa1.nome = "Adalberto";
    pessoa1.idade = 70;
    

    Pessoa pessoa1 = new Pessoa{
        nome = "Douglas",
        idade = 28
    }
    */

    //instanciando um objeto com método construtor
    Pessoa pessoa1 = new Pessoa("Vini", 16);
    pessoa1.Cantar();
    Pessoa pessoa2 = new Pessoa("Nicolas", 16);
    pessoa2.Cantar();
    Pessoa pessoa3 = new Pessoa("Cauã", 17);
    pessoa3.Cantar();
}
}