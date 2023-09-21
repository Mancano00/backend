//O namespace é o nome q usaremos para fazer referência quando usarmos
namespace Sesi.Model
{
    //Declarando a class Aluno
    public class Aluno
    {
        //Declarando os atributos da class Aluno
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

        //Declarando um atributo privado
        private int nrFaltas { get; set; }

        //Criando Método
        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {nome}, eu tenho {idade} anos e estudo na turma do {turma}");
        }
        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"O aluno {nome} faltou hoje, contando com {nr} faltas");
            nrFaltas += nr;
        }

        public void ResumoFaltas()
        {
            Console.WriteLine($"O aluno {nome} tem {nrFaltas} faltas");
        }
    }
}