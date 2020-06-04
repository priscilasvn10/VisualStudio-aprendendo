using System;
using System.Collections.Generic;


namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> lista = new List<Funcionario>();
            

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Funcionário #"+(i+1)+": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.Write("Salário: ");
                double sal = double.Parse(Console.ReadLine());

                Funcionario f = new Funcionario(id, nome, sal);
                lista.Add(f);
   
            }

            Console.WriteLine();
            Console.Write("digite o Id que terá aumento: ");
            int buscaId = int.Parse(Console.ReadLine());

            int posicao = lista.FindIndex(x => x.Id == buscaId);
            if(posicao == -1)
            {
                Console.WriteLine("Id não encontrado!");
            }
            else
            {
                Console.WriteLine("Digite a porcentagem de aumento: ");
                double aumento = double.Parse(Console.ReadLine());
                lista[posicao].incrementoSalario(aumento);
            }

            Console.WriteLine();
            Console.WriteLine("Listagem autalizada de funcionários: ");

            for(int i =0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

        }
    }
}
