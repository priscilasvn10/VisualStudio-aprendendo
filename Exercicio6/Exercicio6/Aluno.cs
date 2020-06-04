using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6
{
    class Aluno
    {

        public String Nome;
        public Double Nota1, Nota2, Nota3;

        public double Media()
        {
           return (Nota1 + Nota2 + Nota3);
        }

   
        public String Final()
        {
            if (Media()< 60)
            {
              return "Reprovado! \n" + "Faltam "+ (60 - Media()) + " pontos";
            }
            else
            {
              return   "Aprovado!";
            }
        }
    }
}
