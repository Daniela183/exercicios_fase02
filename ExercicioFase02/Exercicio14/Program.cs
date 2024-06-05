Console.WriteLine("\n14- Escreva um programa que solicite a temperatura em graus Celsius e converta para Kelvin e Farhenheit usando as fórmulas a seguir:" +
    "\r\n- Converter para Kelvin => K = C + 273 ;\r\n- Converter para Farhenheit => F = (C * 9) / 5 + 32;");

Console.Write("\nInforme o valor em graus Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"\nGraus Kelvin = {celsius + 273}");
double farhenheit = (celsius * 9) / 5 + 32;
Console.WriteLine($"\nGraus Fahrenheit = {farhenheit}");

Console.ReadKey();