using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppingsTo10;

        public Pizza(string name)
        {
            Name = name;
            this.Dough = dough;
            this.toppingsTo10 = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new Exception($"Pizza {name} should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Dough Dough { get => dough; set => dough = value; }



        public void AddTopping(Topping topping)
        {
            if (toppingsTo10.Count == 10)
            {
                throw new Exception($"Number of toppings should be in range [0..10].");
            }
            toppingsTo10.Add(topping);
        }
        public double totalCalorie()
        {
            foreach (var topping  in toppingsTo10)
            {

            }

            return 234;
        }


    }
}
