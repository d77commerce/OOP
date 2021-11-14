using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.food;

namespace WildFarm.animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Fruits || food is Vegetable)
            {
                FoodEaten = food.Qty;
                Weight += food.Qty * 0.10;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string Saund()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
