// Fazer um programa para ler os valores da largura e altura de um retângulo.
// Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.

// Retângulo
// Largura: double
// Altura: double
// + Area(): double
// + Perimetro(): double
// + Diagonal(): double

// Exemplo:
// Entre a largura e altura do retângulo:
// 3.00
// 4.00
// AREA = 12.00
// PERÍMETRO = 14.00
// DIAGONAL = 5.00

using Exercicio6;
using System;
using System.Globalization;

Retangulo area = new Retangulo();

Console.WriteLine("Digite a largura e altura do retângulo: ");
area.Largura=  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
area.Altura= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine("AREA = " + area.CalcArea().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("AREA = " + area.CalcPerimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("AREA = " + area.CalcDiagonal().ToString("F2", CultureInfo.InvariantCulture));
