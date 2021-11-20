using System;

namespace PizzaCalories
{
   public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInput = Console.ReadLine().Split();

                Pizza pizza = new Pizza(pizzaInput[1]);


                string[] input = Console.ReadLine().Split();
                string flourType = input[1];
                string bakingTechnique = input[2];
                double grams = double.Parse(input[3]);
                Dough dough = new Dough(flourType, bakingTechnique, grams);
                pizza.Dough = dough;
                string inputTopping;
                Topping topping = null;
                double totalToppingCalorie = 0;
                while ((inputTopping = Console.ReadLine()) != "END")
                {
                    string[] curantTopping = inputTopping.Split();
                    string type = curantTopping[1];
                    double gramsTopping = double.Parse(curantTopping[2]);

                    topping = new Topping(type, gramsTopping);
                    pizza.AddTopping(topping);
                    totalToppingCalorie += topping.CaloriesTopping();
                }

                double total = totalToppingCalorie + dough.Calories();
                Console.WriteLine($"{pizza.Name} - {total:f2} Calories.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
