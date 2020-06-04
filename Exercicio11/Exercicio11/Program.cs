using System;
using System.Collections.Generic;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos?");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for(int x =0; x<i; x++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }



            Console.Write("O curso B possui quantos alunos?");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int x = 0; x < i; x++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }



            Console.Write("O curso C possui quantos alunos?");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int x = 0; x < i; x++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

             A.UnionWith(B); 
             A.UnionWith(C);

            int cont = A.Count;


            Console.Write("Total de alunos: " + cont);

        }
    }
}
