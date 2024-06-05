Console.WriteLine("12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no console o resultado das seguintes " +
    "operações : (x^2 -> x ao quadrado) (pi = 3.1415)\n");

Console.Write("Informe o valor de x : ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"-6 + x * 5 = {-6 + x * 5}");
Console.WriteLine($"(13 - 2) * x = {(13 - 2) * x}");
Console.WriteLine($"(x + -2) * (20 / x) = {(x + -2) * (20 / x)}");
Console.WriteLine($"(12 + x) / (x - 4) = {(12 + x) / (x - 4)}");
Console.Write("3 x^2 + x + 10 = ");
double resultado = 3 * Math.Pow(x, 2) + x + 10;
double area = Math.PI * Math.Pow(x, 2);

Console.WriteLine($"3 * x^2 + x + 10 = {resultado}");
Console.WriteLine($"pi * x^2 = {area}");

Console.ReadKey();