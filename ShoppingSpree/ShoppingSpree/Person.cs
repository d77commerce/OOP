using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private decimal money;
        private string name;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            ProductsAdd = new List<Product>();

        }

        public string Name 
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be empty");
                   
                }
                else
                {
                     name = value;
                }
               
            }
            }
        public decimal Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                    return;
                }
                else
                {
                    money = value;
                }

            }
        }

        public List<Product> ProductsAdd { get; private set; }
        public void Buying(Product product)
        {
            if (product.Cost > Money)
            {
                Console.WriteLine($"{Name} can't afford {product.ProductName}");
            }
            else
            {
                Money -= product.Cost;
                ProductsAdd.Add(product);
            }

        }
        public override string ToString()
        {
            return $"{Name} - {(ProductsAdd.Any() ? string.Join(", ", ProductsAdd) : "Nothing bought")}";
        }
    }
}
