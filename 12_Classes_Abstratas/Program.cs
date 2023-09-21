//Classe pai que será herdada - SuperClasse


abstract class Animal
{
    public string cor { get; set; }
    public abstract void EmitirSom();
}

//Criando classe filha que herdará da classe Animal
class Cachorro : Animal
{
    //Sobrescrevendo o método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"Cachorro da cor {cor} está latindo! Au au au");
    }
}
class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} está miando! Miau miau");
    }
    public void Ronronar()
    {
        Console.WriteLine("O gato está ronronendo!");
    }
}

class program
{
    public static void Main()
    {
        /*  //Não é permitido criar um objeto de uma classe abstrata
            //Só de uma classe derivada
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();*/
        
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        
        Gato meuGato = new Gato();
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}