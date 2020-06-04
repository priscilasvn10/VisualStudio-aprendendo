using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio13.Entities
{
    class Client
    {

        public string  Name { get; set; }
        public string Email { get; set; }
        public DateTime BrithDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime brithDate)
        {
            Name = name;
            Email = email;
            BrithDate = brithDate;
        }

        public override string ToString()
        {
            return Name
                + ", ("
                + BrithDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }

    }
}
