using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Área = " + ret.Area());
            Console.WriteLine("Perímetro = " + ret.Perimetro());
            Console.WriteLine("Diagonal = " + ret.Diagonal());

        }
    }
}
