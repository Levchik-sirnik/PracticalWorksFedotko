using System;
using System.Collections.Generic;
using System.Text;

namespace Practice7_1
{
    internal class Product
    {
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
