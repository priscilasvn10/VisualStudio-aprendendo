using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio8
{
    class Aluguel
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public int Quarto { get; set; }

        public Aluguel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", "+ Email;
        }

    }
}
