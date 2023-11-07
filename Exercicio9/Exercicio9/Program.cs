// Fazer um programa para ler um valor numérico.
// mostrar o valor da circunferência e do volume de uma esfera para esse valor.
// Informaro valor de PI com 2 casas decimais.

using Exercicio9;
using System.Globalization;



Console.Write("Digite o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circunferencia = Calculadora.Circunferencia(raio);
double volume = Calculadora.Volume(raio);

Console.WriteLine("Circunferência: " + circunferencia.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor de PI: " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));