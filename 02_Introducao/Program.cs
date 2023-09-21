//Somente declaramos a variável como inteira e não atribuimos valor 
int num1;

//Declarando uma variável do tipo inteira e atribuindo valor 5
int num2 = 5;

//Declarando um variável de tipo string
string nomeAluno;

//Variável do tipo lógico (verdadeiro ou falso)
bool resultado = true;

//Variável do tipo valor com casas decimais - para valores mais precisos
double coordenada = 1.80;

//Variável do tipo decimal - mais usada para valor monetário
decimal valor = 1.80M;

int idade = 16;
string nome = "Nícolas";
Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");

Console.WriteLine("Em que cidade você nasceu?");
//Recebendo uma informação do usuário e atribuindo na variável cidade
string cidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {cidade}");

int NovaIdade = idade + 5;
int AnoNascimento = 2023 - idade;
Console.WriteLine($"Você nasceu em {AnoNascimento} e daqui 5 anos terá {NovaIdade}");