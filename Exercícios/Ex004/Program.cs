class Program
{
     public static void Main()
    {
        DobroMetade();

        TabuadaComWhile();

        SomaComDoWhile();
    }

      public static void DobroMetade()
    {
        int n;
        Console.WriteLine("Digite um nº");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine($"O dobro do nr {n} é {n * 2} e a metade é {n / 2}");
    }

    public static void TabuadaComWhile()
    {
        int n;
        int contador = 1;

        Console.WriteLine("Digite um nº");
        n = int.Parse(Console.ReadLine());
        while (contador <= 10)
        {
            Console.WriteLine($"{contador} X {n} = {contador * n}");
            contador++;
        }
    }

    public static void SomaComDoWhile()
    {
        int n = 0;
        int menor = 10000;
        int maior = 0;
        int soma = 0;

        do{
            Console.WriteLine("Digite um nº");
            n = int.Parse(Console.ReadLine());
            if (n > maior){
                maior = n;
            }
            if (n < menor && n > 0){
                menor = n;
            }
            if(n > 0)
            {
                soma += n;
            }
            
        }while(n > 0);

         Console.WriteLine($"Menor é {menor}, Maior é {maior}, resultado é {soma}");
    }
}
