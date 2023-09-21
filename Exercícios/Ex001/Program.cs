Console.WriteLine("Nome do aluno");
string Aluno = Console.ReadLine();

Console.WriteLine("Digite a nota 1:");
int Nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 2:");
int Nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 3:");
int Nota3 = int.Parse(Console.ReadLine());

int notaFinal = (Nota1 + Nota2 + Nota3) / 3;

string passou = (notaFinal >= 7) ? " Passou  " : " Não passou ";
Console.WriteLine($"O aluno {Aluno} tirou {Nota1}, {Nota2} e {Nota3}, média dele foi de {notaFinal}. Ele {passou}");
