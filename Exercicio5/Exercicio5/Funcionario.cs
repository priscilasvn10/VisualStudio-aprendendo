using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class Funcionario
    {
        public String Nome;
        public Double SalarioBruto;
        public Double Imposto;

        public Double SalarioLiquido()
        {
            return SalarioBruto - Imposto; 
        }

        public void AumentarSalario(Double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);

        }

        public override string ToString()
        {
            return "Funcionário : " + Nome + ", R$ " + SalarioLiquido().ToString("F2");
        }
    }
}
