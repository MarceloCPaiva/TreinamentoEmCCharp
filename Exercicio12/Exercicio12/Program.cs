// Fazer um programa que inicie com todos os dez quartos vazios,
// e depois leia uma quantidade N representando o número de estudantes que vão
// alugar quartos (N pode ser de 1 a 10).
// Em seguida, registre o aluguel dos N estudantes.
// Para cada registro de aluguel, informar o nome e email do
// estudante, bem como qual dos quartos ele escolheu (de 0 a 9).
// Suponha que seja escolhido um quarto vago.
// Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato, por ordem de quarto, conforme exemplo.

using Exercicio12;
using System.Globalization;

Students[] vect = new Students[10];

Console.Write("Quantos quartos serão alugados? ");
int roomsToBeRented = int.Parse(Console.ReadLine());


for (int i = 1; i <= roomsToBeRented; i++)
{
    Console.WriteLine();
    Console.WriteLine("Aluguel #" + i + ":");

    Console.Write("Nome: ");
    string name = Console.ReadLine();

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("Quarto: ");
    int chosenRoom = int.Parse(Console.ReadLine());
    vect[chosenRoom] = new Students(name, email);
}

Console.WriteLine();
Console.WriteLine("Quartos ocupados: ");

for (int i = 0; i < 10; i++)
{
    if (vect[i] != null)
    {
        Console.WriteLine(i + ": " + vect[i]);
    }
}