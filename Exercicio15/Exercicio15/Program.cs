// Exercício de produtos Importados, Sem ser importados e Usados

using System.Globalization;
using Exercicio15.Entities;

Console.Write("Enter the number of Products: ");
int numberOfProducts = int.Parse(Console.ReadLine());
Console.WriteLine();

//Declarando uma lista
List<Product> products = new List<Product>();

//Percorrer a lista
for (int i = 1; i <= numberOfProducts; i++)
{ 
    Console.WriteLine($"Product #{i} data: ");
    Console.WriteLine();

    Console.Write("Common, used or imported (c/u/i)? ");
    char typeProduct = char.Parse(Console.ReadLine());
    Console.WriteLine();

    if (typeProduct == 'c')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        products.Add(new Product(name, price));
    }
    else if (typeProduct == 'i')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        products.Add(new ImportedProduct(name, price, customsFee));
    }
    else 
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

        products.Add(new UsedProduct(name, price, manufactureDate));

    }

    Console.WriteLine();
}

//Saída de dados

Console.WriteLine();
Console.WriteLine("PRICE TAGS: ");
foreach (Product emp in products)
{
   Console.WriteLine($"{emp.PriceTag()}");
}