using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Produto
    {

        public String Nome;
        public double Preco;
        public int Quant;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quant;
        }

        public void AdicionarProdutos(int quant)
        {
            Quant += quant;
        }

        public void RemoverProdutos(int quant)
        {

            Quant -= quant;
        }


        public override string ToString()
        {
            return Nome 
                + ", R$ " + Preco.ToString("F2") 
                + ",  " + Quant + " unidades, " + "R$ " 
                + ValorTotalEmEstoque().ToString("F2");
        }


    }
}
