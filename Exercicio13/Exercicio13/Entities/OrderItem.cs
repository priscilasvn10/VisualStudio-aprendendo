using System;
using System.Collections.Generic;
using System.Text;
using Exercicio13.Entities;

namespace Exercicio13.Entities
{
    class OrderItem
    {

        public int Quantily { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantily, double price, Product product)
        {
            Quantily = quantily;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantily;
        }

        public override string ToString()
        {
            return Product.Name
                + ", R$ "
                + Price.ToString("F2")
                + ", Quantity: "
                + Quantily
                + ", Subtotal: R$ "
                + SubTotal().ToString("F2");
        }


    }
}
