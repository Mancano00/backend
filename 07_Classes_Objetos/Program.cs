using Sesi.Model;

class program
{
    public static void Main()
    {
        //Criando uma variavel Aluno1 e instanciando da classe Aluno
        var Aluno1 = new Aluno();
        //Criando nosso objeto
        Aluno1.nome = "pica-pau";
        Aluno1.idade = 16;
        Aluno1.turma = "2º EM";

        //Chamando o método da classe Aluno

        Aluno1.Apresentar();
        Aluno1.AdicionarFaltas(10);
        Aluno1.Apresentar();

        Aluno Aluno2 = new Aluno();
        Aluno2.nome = "Nícolas";
        Aluno2.idade = 16;
        Aluno2.turma = "2º EM";

        Aluno2.Apresentar();
        Aluno2.AdicionarFaltas(10);
        Aluno2.Apresentar();

        Aluno Aluno3 = new Aluno();
        Aluno3.nome = "Nícolas";
        
        Aluno3.ResumoFaltas();
    }
}