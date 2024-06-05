Console.WriteLine("9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’" +
    " e a senha for igual a ‘123’ então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login inválido’: (use o operador condicional ternário)\r\n");
Console.Write("Informe o nome: ");
string nome = Console.ReadLine();

Console.Write("Informe a senha: ");
int senha = Convert.ToInt32(Console.ReadLine());

var resultado = (nome == "admin" || nome == "maria" || nome == "Admin" || nome == "Maria") && senha == 123 ? "Login feito com sucesso" : "Login inválido";
Console.WriteLine(resultado);

Console.ReadKey();