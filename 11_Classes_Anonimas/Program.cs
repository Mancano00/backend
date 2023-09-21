public class Program
{

    public static void Main()
    {
        var pessoa1 = new
        {
            nome = "João", idade = 20
        };
        var pessoa2 = new
        {
            nome = "Maria", idade = 17
        };
        Console.WriteLine($"A pessoa 1 se chama {pessoa1.nome} e a pessoa 2 {pessoa2.nome}");
        //Atividade
        Console.WriteLine("digite o modelo do carro");
        string modeloDigitado = Console.ReadLine();
        Console.WriteLine("digite o ano do carro");
        string anoDigitado = Console.ReadLine();
        Console.WriteLine("digite o marca do carro");
        string marcaDigitado = Console.ReadLine();
        var carro1 = new
        {
            marca = marcaDigitado,
            modelo = modeloDigitado,
            ano = anoDigitado
        };
        Console.WriteLine($"O modelo de carro é {carro1.modelo}, da marca {carro1.marca} e ano {carro1.ano}");

    }
}