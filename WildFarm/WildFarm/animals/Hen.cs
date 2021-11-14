using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.food;

namespace WildFarm.animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

      
        public override void Eat(IFood food)
        {
            FoodEaten  = food.Qty;
            Weight += food.Qty*0.35;
        }

        public override string Saund()
        {
            return "Cluck";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
