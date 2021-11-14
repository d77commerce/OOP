using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.food;

namespace WildFarm
{
  public interface IAnimal
    {
        public string  Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }
        string Saund();
        void Eat(IFood food);
    }
}
