using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {

        private string flourType;
        private string baking;
        private double grams;

        Dictionary<string, double> bakingTexCalories = new Dictionary<string, double>
        {
            {"Crispy", 0.9 },
            {"Chewy",1.1 },
            {"Homemade",1.0 }
        };
        public Dough(string flourType, string baking, double grams)
        {
            FlourType = flourType;
            Baking = baking;
            Grams = grams;
        }

        public string FlourType
        {
            get { return flourType; }
           private set
            {
                if (value != "White" && value != "Wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
             flourType = value;

            }
        }


        public string Baking
        {
            get { return baking; }
           private set { baking = value; }
        }


        public double Grams
        {
            get { return grams; }
          private  set
            {
                if (value > 0 && value <= 200)
                {
                    grams = value;
                }
                else
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }

            }
        }
        public double Calories()
        {
            double curentFlourCalories = 0;
            if (flourType == "White")
            {
                curentFlourCalories = grams * 1.5*2*bakingTexCalories[baking];
            }
            else if (flourType== "Wholegrain")
            {
                 curentFlourCalories = grams*2*bakingTexCalories[baking];
            }
            return curentFlourCalories;
        }

    }
}
