using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int l = int.Parse(valores[0]);
            int c = int.Parse(valores[1]);

            int[,] matriz = new int[l,c];

           // Console.WriteLine("l: "+ l + "C: " + c);

            for(int i = 0; i<l; i++)
            {
                valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < c; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                    //Console.WriteLine("Linha: " +i+ "Coluna: " +j +"Valor: " + matriz[i,j]);

                }
            }

            int verifica = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < l; i++)
            {
               for (int j = 0; j < c; j++)
                {
                    if (matriz[i, j] == verifica)
                    {
                        
                        if (j> 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                          if (j < c-1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                          if (i > 0)
                        {
                            Console.WriteLine("Cima: " + matriz[i - 1, j]);
                        }
                         if ( i < l-1)
                        {
                            Console.WriteLine("Baixo: " + matriz[i + 1, j]);
                        }

                        j = c;
                        i = l;
                    }
                }
        }   }         
                
    }
}
