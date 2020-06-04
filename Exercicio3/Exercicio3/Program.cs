using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            int qtd;

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quant = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("-------------------------------------");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Dados atualizados: "+ p);

            Console.WriteLine("-------------------------------------");

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Dados atualizados: " + p);




        }
    }
}
