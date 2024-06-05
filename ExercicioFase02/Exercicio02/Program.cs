using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.\n");
string nome = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine($"{nome} \ntem {idade} anos \ne nota {nota}\n");

Console.ReadKey();