using Model;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Digite se nome:");
        string nomeTitular = Console.ReadLine();
        Console.WriteLine($"Bem-Vindo a sua conta, {nomeTitular}");
        ContaCorrente titular = new ContaCorrente(nomeTitular);



        string opcao = "";

        do
        {
            Console.WriteLine("¦¦¦¦¦¦¦¦¦¦¦ M E N U ¦¦¦¦¦¦¦¦¦¦¦");
            Console.WriteLine("    1-Para ver o seu saldo     ");
            Console.WriteLine(" 2-Para depositar seu dinheiro ");
            Console.WriteLine("   3-Para sacar seu dinheiro   ");
            Console.WriteLine("    0-Para fechar o sistema    ");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre !!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    titular.CosultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Qual o valor que vc quer depositar?");
                    decimal deposito = decimal.Parse(Console.ReadLine());
                    titular.depositar(deposito);
                    break;
                case "3":
                    Console.WriteLine("Qual o valor que você quer sacar?");
                    decimal saque = decimal.Parse(Console.ReadLine());
                    titular.Sacar(saque);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        } while (opcao != "0");
    }
}
