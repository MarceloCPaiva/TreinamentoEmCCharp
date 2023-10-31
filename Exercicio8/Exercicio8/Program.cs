// Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
// (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada).
// Ao final, mostrar qual a nota final do aluno no ano.
// Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos).
// Você deve criar uma classe Aluno para resolver este problema.

using Exercicio8;
using System.Globalization;

Aluno aluno = new Aluno();

Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno: ");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



Console.WriteLine();
Console.WriteLine("Nota final = " + aluno.Media().ToString("F2", CultureInfo.InvariantCulture));

if (aluno.Media() >= 60)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
    Console.WriteLine("Faltaram " + aluno.PontosParaAprovacao().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
}