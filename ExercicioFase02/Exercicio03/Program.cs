Console.WriteLine("5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings");

char letra1, letra2, letra3;
Console.Write("Informe a letra: ");
letra1 = Convert.ToChar(Console.ReadLine());
Console.Write("Informe a letra: ");
letra2 = Convert.ToChar(Console.ReadLine());
Console.Write("Informe a letra: ");
letra3 = Convert.ToChar(Console.ReadLine());
Console.WriteLine(letra3 + " " + letra2 + " " + letra1);
Console.WriteLine($"{letra3} {letra2} {letra1}");

Console.ReadKey();