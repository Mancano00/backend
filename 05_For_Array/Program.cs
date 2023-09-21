class program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Estou passando pelo {i}ª vez no bloco");
        }

        int num = 5;
        for (int cont = 1; cont <= 10; cont++)
        {
            Console.WriteLine($"{num} x {cont} = {num * cont}");
        }

    //Declarando Vetor do tipo inteiro com 4 espaços
        int[] notas = new int[4];
    //Atribuindo valor
        string[] meses = {"Jan", "Fev"};

        int[] alunos = new int[6];
        alunos[4] = 3;
        alunos[5] = 11;
        alunos[3] = 7;
        alunos[0] = 20;
        alunos[2] = 8;
        alunos[1] = 12;

        int soma = 0;
        int Maior = 0;
        int Menor = 10000;
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
        }
        foreach (int item in alunos)
        {
            soma = soma + item;
            if (item > Maior)
            {
                Maior = item;
            }
            if (item < Menor)
            {
                Menor = item;
            }
        }

        Console.WriteLine($"Soma é {soma} o  maior é {Maior} o menor é {Menor}");

        Array.Sort(alunos);

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
        }
    
    }
}