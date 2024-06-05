Console.WriteLine("7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir realize as operações de soma, subtração, multiplicação, " +
    "exponenciação, divisão e módulo exibindo o resultado:\n");

Console.Write("Informe o valor de x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("\nInforme o valor de y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\nA soma de x + y = {x + y}");
Console.WriteLine($"A subtração de x - y = {x - y}");
Console.WriteLine($"A multiplicação de x * y = {x * y}");
Console.WriteLine($"O exponencial de x = {Math.Exp(x)}");
Console.WriteLine($"O exponencial de y = {Math.Exp(y)}");
double divisao = (double)x / y;
Console.WriteLine($"A divisão de x / y = {divisao}");
Console.WriteLine($"O módulo de x % y = {x % y}");

Console.ReadKey();