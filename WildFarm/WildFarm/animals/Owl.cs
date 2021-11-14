using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.food;

namespace WildFarm.animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
           if (food is Meat)
            {
                FoodEaten = food.Qty;
                Weight += food.Qty * 0.25;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string Saund()
        {
            return "Hoot Hoot";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name} {WingSize} {Weight} {FoodEaten}]";

        }
    }
}
