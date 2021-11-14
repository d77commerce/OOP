using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.food;

namespace WildFarm.animals
{
    public class Cat : Felines
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Meat || food is Vegetable)
            {
                FoodEaten = food.Qty;
                Weight += food.Qty * 0.30;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string Saund()
        {
            return "Meow";
        }
        public override string ToString()
        {
              return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
