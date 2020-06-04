using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7
{
    class ContaBancaria
    {

        public int Numero { get; private set; }
        public String Titular { get; set; }
        public double Saldo { get; private set; }


        // Contrutores 
        public ContaBancaria(int numero, String titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, String titular, double saldo): this(numero, titular)
        {
             Deposito(saldo);
        }

        
        //--------------------------------------------

        
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque (double quantia)
        {

             Saldo -= quantia;
            Saldo -= 5.0;
            
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: "+Titular +", Saldo: R$ "+Saldo.ToString("F2") ;
        }



    }
}
