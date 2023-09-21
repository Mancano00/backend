namespace Models
{
    public class Pessoa
    {
        private string nome { get; set; }
        private int idade { get; set; }

        //Criando método construtor
        public Pessoa (string nomePesso, int idadePessoa)
        {
            this.nome = nomePesso;
            this.idade = idadePessoa;
        }
        public void Cantar()
        {
            Console.WriteLine($"{nome} com {idade} anos, está cantando");
        }
    }
}