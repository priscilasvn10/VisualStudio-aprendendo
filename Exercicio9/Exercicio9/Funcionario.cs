using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio9
{
    class Funcionario
    {
        public int Id { get; private set; }
        public String Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            this.Id = id;
           this.Nome = nome;
            this.Salario = salario;
        }

        public void incrementoSalario(double porcento)
        {
            Salario = Salario + (Salario * porcento)/100;
        }

        public override string ToString()
        {
            return Id + ", " + Nome+ ", " + Salario.ToString("F2");
        }
    }
}
