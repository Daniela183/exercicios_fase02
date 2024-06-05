//aula 42
using Microsoft.VisualBasic;

Console.WriteLine("Exercícios Propostos fase 02");
Console.WriteLine("1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : " +
    "\r\nAluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.\n");

string nome = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine($"{nome} tem {idade} anos e nota {nota}\n");
Console.WriteLine(nome + " tem " + idade + " anos e nota " + nota);

Console.ReadKey();
