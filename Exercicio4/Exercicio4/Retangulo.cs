using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4
{
    class Retangulo
    {

        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;

        }

        public double Perimetro()
        {
            return (Altura * 2) + (Largura * 2);
        }

        public double Diagonal()
        {

            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}
