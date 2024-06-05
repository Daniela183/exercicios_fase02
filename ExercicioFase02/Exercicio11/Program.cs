Console.WriteLine("11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no console se x é par ou não e se y é par ou não. " +
    "Use o operador condicional ternário (? :)");

Console.Write("\nInforme o valor de x : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y : ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(x % 2 == 0 ? "x é par " : "x é ímpar");
Console.WriteLine(y % 2 == 0 ? "y é par " : "y é ímpar");

Console.ReadKey();