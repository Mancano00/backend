using Sesi.Models;
class program
{
    public static void Main()
    {
        Gato meuGato = new Gato();
        meuGato.nome = "Garfield";
        meuGato.cor = "Preto";
        meuGato.idade = 2;
        meuGato.especie = "Vira-Lata";
        meuGato.genero = "Macho";
        meuGato.peso = 3;
        meuGato.EmitirSom();

        Peixe meuPeixe = new Peixe();
        meuPeixe.cor = "Laranja";
        meuPeixe.especie = "Palhaço";
        meuPeixe.tamanho = 0.20M;
        meuPeixe.peso = 0.100M;
        meuPeixe.EmitirSom();
    }
}
