using System;
using Exercicio13.Entities;
using Exercicio13.Entities.Enum;
using System.Globalization;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente: ");
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("Email: ");
            string e = Console.ReadLine();           
            Console.Write("Birth date(DD / MM / YYYY): ");
            DateTime d = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order: ");
            Console.WriteLine("Status: ");
            Orderstatus status = Enum.Parse<Orderstatus>(Console.ReadLine());



            Client cli = new Client(n, e, d);
            Order order = new Order(DateTime.Now, status, cli);



            Console.Write(" How many items to this order ? ");
            int x = int.Parse(Console.ReadLine());

      
                for(int i = 1; i<= x; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string no = Console.ReadLine();
                Console.Write("Product price: ");
                double p = double.Parse(Console.ReadLine());

                Product pro = new Product(no, p);


                Console.Write("Quantity:");
               int q = int.Parse(Console.ReadLine());


                OrderItem oi = new OrderItem(q, p, pro);

                order.AddItem(oi);


            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");

            Console.WriteLine(order);
           


        }
    }
}
