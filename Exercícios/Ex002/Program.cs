Console.WriteLine("Digite o número da sua placa");
string Placa = Console.ReadLine();

string final = Placa.Substring(Placa.Length - 1, 1);

if (final == "1" || final == "2")
{
    Console.WriteLine("Você não pode andar com o carro na Segunda");
}
else if (final == "3" || final == "4")
{
    Console.WriteLine("Você não pode andar com o carro na Terça");
}
else if (final == "5" || final == "6")
{
    Console.WriteLine("Você não pode andar com o carro na Quarta");
}
else if (final == "7" || final == "8")
{
    Console.WriteLine("Você não pode andar com o carro na Quinta");
}
else
{
    Console.WriteLine("Você não pode andar com o carro na Sexta");
}