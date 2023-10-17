// Treinando Entrada e saída de dados

using System.Globalization;

int quartos, idade;
string nomeCompleto, ultimoNome;
double precoProduto, altura;

Console.WriteLine("Entre com o seu nome completo: ");
nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa? ");
quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
precoProduto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com o seu último nome, idade e altura (na mesma linha) ");
string[] vet = Console.ReadLine().Split(' ');

ultimoNome = vet[0];
idade = int.Parse(vet[1]);
altura = double.Parse(vet[2]);

Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));