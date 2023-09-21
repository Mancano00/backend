 class program
 {
    public static void Main()
    {
        //ListaDoChurrasco();
        SonhosDeConsumo();
    }
    public static void ListaDoChurrasco()
    {
        string[] produtos = new string[6];
        for (int i = 0; i < produtos.Length; i++){
            Console.WriteLine("Digite os produtos");
            string atribui = Console.ReadLine();
            produtos[i] = atribui;
        }

        Array.Sort(produtos);


        foreach(string item in produtos)
        {
            Console.WriteLine($"Os produtos da lista são: {item}");
        }
    }

    public static void SonhosDeConsumo()
    {
        string[] sonhos = new string[3];
        int[] custo = new int[3];
        int soma = 0;
        for (int i = 0; i < sonhos.Length; i++){
            Console.WriteLine("Digite os seus sonhos");
            string atribui = Console.ReadLine();
            sonhos[i] = atribui;

            Console.WriteLine("Digite os custos");
            int valor = int.Parse(Console.ReadLine());
            custo[i] = valor;
        }

        foreach(int item in custo)
        {
            soma += item;

            Console.WriteLine($"Seus sonhos custará R$ {soma}");
        }
    }
 }