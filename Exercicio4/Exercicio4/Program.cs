// Fazer um programa para ler nome e salário de dois funcionários. 
// Depois, mostrar o salário médio dos funcionários.

using Exercicio4;
using System.Globalization;

Funcionario primeiroFuncionario, segundoFuncionario;

primeiroFuncionario = new Funcionario();
segundoFuncionario = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário: ");
Console.Write("Nome: ");
primeiroFuncionario.nome = Console.ReadLine();
Console.Write("Salário: ");
primeiroFuncionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine("Dados do segundo funcionário: ");
Console.Write("Nome: ");
segundoFuncionario.nome = Console.ReadLine();
Console.Write("Salário: ");
segundoFuncionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

double mediaSalario = (primeiroFuncionario.salario + segundoFuncionario.salario) / 2;
Console.WriteLine("Salário médio = " +  mediaSalario.ToString("F2", CultureInfo.InvariantCulture));