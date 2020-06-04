using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Double pormais;

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = Double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(f);
            Console.WriteLine("_____________________________________");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            pormais = double.Parse(Console.ReadLine());
            f.AumentarSalario(pormais);

            Console.WriteLine("Dado atualizado: " +f);

        }
    }
}
