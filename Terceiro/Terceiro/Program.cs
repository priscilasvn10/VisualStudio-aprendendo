using System;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {

            double xa, xb, xc, ya, yb, yc, areax, areay;

            Console.WriteLine("Entre com as medidas do triângilo X: ");
            xa = double.Parse(Console.ReadLine());
            xb = double.Parse(Console.ReadLine());
            xc = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângilo Y: ");
            ya = double.Parse(Console.ReadLine());
            yb = double.Parse(Console.ReadLine());
            yc = double.Parse(Console.ReadLine());

            areax = CalcArea(xa, xb, xc);
            areay = CalcArea(ya, yb, yc);

            Console.WriteLine("Área de X: "+ areax.ToString("F2"));
            Console.WriteLine("Área de Y: " + areay.ToString("F2"));

            if(areax > areay)
            {
                Console.WriteLine("Maior área : X");
            }
            else
            {
                Console.WriteLine("Maior área : Y");
            }

        }

        static double CalcArea(double a, double b, double c)
        {
            double p, area;

            p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        
        }
    }
}
