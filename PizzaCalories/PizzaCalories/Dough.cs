using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {

        private string flourtype;
        private string baking;
        private double grams;

        public Dough(string flourType, string baking, double grams)
        {
            FlourType = flourType;
            Baking = baking;
            Grams = grams;
        }

        public string FlourType
        {
            get { return flourtype; }
            set { flourtype = value; }
        }


        public string Baking
        {
            get { return baking; }
            set { baking = value; }
        }


        public double Grams
        {
            get { return grams; }
            set { grams = value; }
        }
        public double Calories()
        {
            return Grams *1.5;
        }

    }
}
