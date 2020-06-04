using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            String titular;
            char x;
            double valor;

            ContaBancaria conta;
           
            Console.Write("Entre com o número da conta: ");     
            numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            x = char.Parse(Console.ReadLine());

            if (x == 's' || x == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, valor);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
           
            Console.WriteLine("Dados da conta: \n" + conta);
            Console.WriteLine();

            Console.Write("Entre um valor de depósito: ");
            valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados:\n"+ conta);

            Console.WriteLine();
            Console.Write("Entre um valor de saque: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados:\n" + conta);
           
        }
    }
}
