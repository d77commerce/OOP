using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double grams;

        public Topping(string type, double grams)
        {
            Type = type;
            Grams = grams;
        }

        //   - 1.2;
        //Veggies - 0.8;
        //Veggies - 1.1;
        //Sauce - 0.9;
        public string Type
        {
            get { return type; }
            private set
            {
                if (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce")
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
        }



        public double Grams
        {
            get { return grams; }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{value} weight should be in the range [1..50].");
                }
                grams = value;
            }
        }
        public double CaloriesTopping()
        {
            double calTopping = 0;
            if (type == "Meat")
            {
                calTopping = grams * 1.5 * 2;
            }
            else if (type == "Veggies")
            {
                calTopping = grams * 0.8 * 2;
            }
            else if (type == "Cheese")
            {
                calTopping = grams * 1.1 * 2;
            }
            else if (type == "Sauce")
            {
                calTopping = grams * 0.9 * 2;
            }

            return calTopping;
        }

    }
}
