// Programa para ler os dados de N figuras e depois mostrar as áreas destas figuras na mesma ordem
using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio16.Entities;
using Exercicio16.Entities.Enums;

List<Shape> shapes = new List<Shape>();

Console.Write("Enter the number of shapes: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"Shape #{i} data: ");
    Console.WriteLine();

    Console.Write("Rectangle or Circle (r/c)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());
    if (type == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();

        shapes.Add(new Rectangle(width, height, color));
    }
    else if (type == 'c')
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapes.Add(new Circle(radius, color));
    }
    else
    {
        Console.WriteLine("Letra digitada inesistente. Digite r ou c.");
    }
}

Console.WriteLine();
Console.WriteLine("SHAPE AREAS: ");
foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}
