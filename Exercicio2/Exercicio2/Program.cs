// Programa para ler as medidas dos lados de dois triângulos X e Y.
// Em seguida mostrar o valor das áreas dos dois triângulos.
// Dizer qual dos dois triângulos possui a maior área.

//Fórmula para calcular a área A, B e C:
// area = raiz quadradada de P(P-A)(P-B)(P-C) onde P= A+B+C / 2

//Programa sem usar Classe

//using System.Globalization;

//double xA, xB, xC, yA, yB, yC, pX, areaX, pY, areaY;

//Console.WriteLine("Entre com as medidas do triângulo X: ");
//xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine("Entre com as medidas do triângulo Y: ");
//yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//pX = (xA + xB + xC) / 2;   
//areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));

//pY = (yA + yB + yC) / 2;
//areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

//Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
//Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

//if  (areaX > areaY)
//{
//    Console.WriteLine("Maior área: X");
//}
//else
//{
//    Console.WriteLine("Maior área: Y");

//}

/////////////////////////////////////////////////////////////////////////////////////////////////////
// Programa com Classe

using Exercicio2;
using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X: ");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double areaX = x.AreaTriangulo();

double areaY = y.AreaTriangulo();

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior área: X");
}
else
{
    Console.WriteLine("Maior área: Y");

}