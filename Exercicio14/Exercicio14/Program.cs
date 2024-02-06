// Programa principal

using System.Collections.Generic;
using System.Globalization;
using Exercicio14.Entities;

Console.Write("Enter the number of employees: ");
int numberOfEmployees = int.Parse(Console.ReadLine());
Console.WriteLine();

//Declarando uma lista para salvar a resposta do número de empregados
List<Employee> list = new List<Employee>();

//Percorrer a lista
for (int i = 1; i <= numberOfEmployees; i++) 
{
    Console.Write($"Employee #{i} data: ");

    Console.Write("Outsourced (y/n)? ");
    char outsourced = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("hours: ");
    int hours = int.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (outsourced == 'y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else 
    {
        list.Add(new Employee(name, hours, valuePerHour));  
    }

    Console.WriteLine();
}

//Saída de dados


Console.WriteLine();
Console.WriteLine("PAYMENTS: ");
foreach (Employee emp in list)
{
    Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
}

