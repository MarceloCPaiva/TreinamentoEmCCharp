// Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

using Exercicio3;

Pessoa primeiraPessoa, segundaPessoa;

primeiraPessoa = new Pessoa();
segundaPessoa = new Pessoa();

Console.WriteLine("Dados da primeira pessoa: ");
primeiraPessoa.nome = Console.ReadLine();
primeiraPessoa.idade = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Dados da segunda pessoa: ");
segundaPessoa.nome = Console.ReadLine();
segundaPessoa.idade = int.Parse(Console.ReadLine());
Console.WriteLine();


if (primeiraPessoa.idade > segundaPessoa.idade)
{
    Console.WriteLine("Pessoa mais velha: " + primeiraPessoa.nome);
}
else
{
    Console.WriteLine("Pessoa mais velha: " + segundaPessoa.nome);

}