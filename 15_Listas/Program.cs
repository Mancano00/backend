using System.Collections.Generic;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
       //Criando listas de números inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos à lista
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(15); //posição [1]
        listaNumeros.Add(20); //posição [2]

        //Contando quantidade de elementos da nossa lista
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        //Acessando dados da lista pelo índice
        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(6); //posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        Console.WriteLine($"________________________________________________");

        //Criem uma nova lista de nomes e adicione alguns nomes para ela e exibam a quantidade de nomes que contém nessa lista
        List<string> listaNome = new List<string>();

        listaNome.Add("Nícolas");
        listaNome.Add("Ian");
        listaNome.Add("Heitor");
        listaNome.Add("Vini");
        listaNome.Add("Pedro");

        foreach (string item in listaNome)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Neste momento temos {listaNome.Count} nomes");

        Console.WriteLine($"________________________________________________");
        
        //Criando lista já atribuindo valores
        List<int> numeros = new List<int> {1,2,3,4,5,6,7,8,9};
        numeros.Add(10);

        //Iterando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"------------");

        numeros.Remove(2); //Remove o elemento buscando pelo conteúdo
        numeros.RemoveAt(4); //Remove o elemento pela posição (índice)
        numeros.RemoveRange(2, 2); //Remove o elemento da posição 2 e os próximos 2

        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

         Console.WriteLine($"________________________________________________");
         
         //Criando lista com objetos da classe Aluno
         List<Aluno> listaAlunos = new List<Aluno>();

         //Adicionando um aluno à listaAlunos
         Aluno novoAluno = new Aluno("Ricardo", 22);
         listaAlunos.Add(novoAluno);

         listaAlunos.Add(new Aluno("Gustavo", 15));
         listaAlunos.Add(new Aluno("Pedro", 25));
         listaAlunos.Add(new Aluno("Carlo", 20));
         listaAlunos.Add(new Aluno("Alice", 12));

         foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"O aluno {item.nome} tem {item.idade} anos");
        }

        //Criando nova lista, filtrando e ordenando por nome
        //LINQ utilizando Sintaxe de consulta
        Console.WriteLine($"------------");

        var consulta = from aluno in listaAlunos
                        where aluno.idade > 18
                        orderby aluno.nome
                        select aluno;

        Console.WriteLine("Lista de alunos maiores de 18 anos");

        foreach(var item in consulta)
        {
            Console.WriteLine($"O aluno {item.nome} te {item.idade}");
        }

        //LINQ utilizando Sintaxe de método
        Console.WriteLine($"------------");

        var metodo = listaAlunos
                            .Where(Aluno => Aluno.idade < 18)
                            .OrderBy(aluno => aluno.nome);

        
        Console.WriteLine("Lista de alunos menores de 18 anos");
        
        foreach(var item in metodo
        )
        {
            Console.WriteLine($"O aluno {item.nome} te {item.idade}");
        }
    }
}