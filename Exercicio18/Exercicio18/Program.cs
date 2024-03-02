// Fazer um programa para ler os dados de uma conta bancária e depois realizar um
// saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
// ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
// saque da conta.

using System.Globalization;
using Exercicio18.Entities;

Console.WriteLine("Insira os dados da conta");

Console.WriteLine();
Console.Write("Número da Conta: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Nome do cliente: ");
string holder = Console.ReadLine();

Console.Write("Saldo Inicial: ");
double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Limite para saque: ");
double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account account = new Account(number, holder, balance, withdrawLimit);

Console.WriteLine();
Console.Write("Insira o valor para saque: ");
double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
    account.Withdraw(amountWithdraw);
    Console.WriteLine("Novo saldo: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
