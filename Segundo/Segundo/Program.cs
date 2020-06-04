using System;
using System.Globalization;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int num;
            double preco;

            Console.WriteLine("Entre com seu nome completo: ");
             nome =  Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: R$ ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string [] vetor = Console.ReadLine().Split(' ');

            string ultimo = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Foi digitado: ");
            Console.WriteLine(nome);
            Console.WriteLine(num);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
