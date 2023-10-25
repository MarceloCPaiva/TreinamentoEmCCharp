// Criar um projeto para ler os dados de um produto em estoque (Nome, Preço e quantidade no estoque).
// Em seguida:
// *Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)
// *Realizar uma entrada no estoque e mostrar novamente os dados do produto
// *Reallizar uma saída no estoque e mostrar novamente os dados do produto
// Criar CLASSE: Produto
// -Nome: string -Preco: double -Quantidade: int
// +ValorTotalEmEstoque(): double +AdiocionarProdutos(quantity: int): void + RemoverProdutos(quantity: int): void

using Exercicio5;
using System.Globalization;

Produto produto = new Produto();

Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
produto.Nome =  Console.ReadLine();

Console.Write("Preço: ");
produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque: ");
produto.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do produto: " + produto);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
int qte = int.Parse(Console.ReadLine());
produto.AdicionarProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + produto);

Console.WriteLine();
Console.Write("Digite o numero de produtos a ser removido do estoque: ");
qte = int.Parse(Console.ReadLine());
produto.RemoverProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados Atualizados: " + produto);
