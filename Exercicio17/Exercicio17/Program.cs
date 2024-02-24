// Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais
// podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um,
// bem como o total de imposto arrecadado.

using System.Collections.Generic;
using System.Globalization;
using Exercicio17.Entities;

List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int numberOfTaxPayers = int.Parse(Console.ReadLine());


for (int i = 1; i <= numberOfTaxPayers; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Tax payer #{i} data: ");

    Console.WriteLine();
    Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine());

    if (type == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine());

        list.Add(new Individual(healthExpenditures, name, anualIncome));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());

        list.Add(new Company(numberOfEmployees, name, anualIncome));
    }
}

double someTax = 0.0;

Console.WriteLine();
Console.WriteLine("TAXES PAID: ");

foreach (TaxPayer tp in list)
{
    double tax = tp.Tax();
    Console.WriteLine($"{tp.Name}: $ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
    someTax += tax;
}

Console.WriteLine();
Console.WriteLine($"TOTAL TAXES: $ {someTax.ToString("F2", CultureInfo.InvariantCulture)}");

