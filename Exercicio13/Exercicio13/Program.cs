// Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
// N funcionários. Não deve haver repetição de id.
// Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
// Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
// mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários.

using Exercicio13;
using System.Globalization;
using System.Collections.Generic;

Employee employee;

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

for (int i = 0; i < n; i++) 
{
    Console.WriteLine();
    Console.WriteLine("Emplyoee #" + (i + 1) + ":");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    while (employees.Exists(e => e.Id == id))
    {
        Console.WriteLine("ID já existe. Informe um ID diferente: ");
        id = int.Parse(Console.ReadLine());
    }

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Employee newEmployee = new Employee(id, name, salary);
    employees.Add(newEmployee);
}

Console.WriteLine();
Console.Write("Enter the employee id that will have salary increase: ");
int idSalaryIncrease = int.Parse(Console.ReadLine());

Employee employeeForIncrease = employees.Find(e => e.Id == idSalaryIncrease);

if (employeeForIncrease != null)
{
    Console.Write("Enter the percentage: ");
    double percIncrease = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    employeeForIncrease.AumentarSalario(percIncrease);
}
else
{
    Console.WriteLine();
    Console.Write("This id does not exist!");
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine("Updated employee list: ");
foreach (Employee obj in employees)
{
    Console.WriteLine(obj);
}