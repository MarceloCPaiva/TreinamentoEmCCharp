// Cadastro de conta bancária em OO

using Exercicio11;
using System.Globalization;

ContaBancaria contaBancaria;

Console.WriteLine("CRIAÇÃO DE CONTA BANCÁRIA");

Console.WriteLine();
Console.Write("Digite o número da conta: ");
int numeroDaConta = int.Parse(Console.ReadLine());

Console.Write("Digite o nome do titular da conta: ");
string nome = Console.ReadLine();

Console.Write("Será feito um depósito inicial? (Digite SIM ou NÃO): ");
string temDeposito = Console.ReadLine();


Console.WriteLine();
if (temDeposito == "SIM" || temDeposito == "sim" || temDeposito == "Sim")
{
    Console.Write("Digite o valor do depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    contaBancaria = new ContaBancaria(numeroDaConta, nome, depositoInicial);
}
else
{
    contaBancaria = new ContaBancaria(numeroDaConta, nome);
}


Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(contaBancaria);

Console.WriteLine();
Console.Write("Digite o valor do depósito: ");
double transacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

contaBancaria.Deposito(transacao);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(contaBancaria);

Console.WriteLine();
Console.Write("Digite um valor para saque: ");
transacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

contaBancaria.Saque(transacao);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(contaBancaria);