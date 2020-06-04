using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] vet = new Aluguel[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aleguel #" + (i + 1) + ":");
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.Write("Email: ");
                String email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Aluguel(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }


            }
        }
    }
}
