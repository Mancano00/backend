class Program
{
    //Método Main é o ponto de entrada de um programa em c#
    public static void Main()
    {
        Console.WriteLine("Estou no método Main");
        Metodo();
        ImprimeDataHora();

        int resultadoSoma = Somar(3, 8);
        Console.WriteLine(resultadoSoma);

        ContagemRegressive(10);

        JogoQueNrSouEu(); 
    }

    public static void Metodo()
    {
        Console.WriteLine("Estou no método / função");
    }
    
    public static void ImprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.Hour.ToString());
        Console.WriteLine(DateTime.Now.ToString());
    }
    
    public static int Somar(int n1, int n2)
    {
        int soma = n1 + n2;
        return soma;
    }

    public static void ContagemRegressive(int n)
    {
        while (n >= 0){
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(1000); //Pausa de 1s
        }
        Console.WriteLine("BOOOOOOOOOOM");
    }

    public static void JogoQueNrSouEu()
    {
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * *");  
        Console.WriteLine("               Bem vindo ao jogo              ");  
        Console.WriteLine("Sorteei um número de 1 a 100, tente adivinha-lo");  
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * *");   
        Console.WriteLine("");

        Random rnd = new Random();
        int nrSorteado = rnd.Next(100);
        int nrDigitado = -1;

        do{
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
                Console.WriteLine("O número digitado é Maior que o sorteado");
            else if (nrDigitado < nrSorteado)
                Console.WriteLine("O número digitado é Menor que o sorteado");
        } while (nrDigitado != nrSorteado);
        Console.WriteLine("Parabens você acertou");
    }
}