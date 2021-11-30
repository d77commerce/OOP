using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Sandwich : SandwichPrototype
    {
        private string bread;
        private string meat;
        private string cheese;
        private string vegetables;

        public Sandwich(string bread, string meat, string cheese, string vegetables)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.vegetables = vegetables;
        }
        private string GetIngrList()
        {
            return $"{this.bread},{this.meat},{this.cheese},{this.vegetables}";
        }

        public override SandwichPrototype Clone()
        {
            string ingridianlist = GetIngrList();
            Console.WriteLine($"cloning {ingridianlist}");
            return (Sandwich) MemberwiseClone() ;
        }
    }
}
