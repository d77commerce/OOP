using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
   public class Product
    {
        public Product(string productName, decimal cost)
        {
            ProductName = productName;
            Cost = cost;
        }

        public string ProductName { get; set; }
        public decimal Cost { get; set; }
        public override string ToString()
           => ProductName;
    }
}
