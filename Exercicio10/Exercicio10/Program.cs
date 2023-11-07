// Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais.
// Informar quantos reais a pessoa vai pagar pelos dólares,
// considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor em dólar.
// Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.

using Exercicio10;
using System.Globalization;

Console.Write("Qual a cotação do dólar: ");
double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos dólares você vai comprar: ");
double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double calc = ConversorDeMoeda.CotarDolar(qtdDolar, cotacaoDolar);


Console.Write("Valor a ser pago em reais: " + calc.ToString("F2", CultureInfo.InvariantCulture));