using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string flourType = input[1];
            string bakingTechnique = input[2];
            double grams = double.Parse(input[3]);
            string inputTopping;
            Dough dough = new Dough(flourType, bakingTechnique, grams);
            Topping topping = null;
            while ((inputTopping = Console.ReadLine()) != "END")
            {
                string[] curantTopping = inputTopping.Split();
                string type = curantTopping[1];
                double gramsTopping = double.Parse(curantTopping[2]);

                 topping = new Topping(type, gramsTopping);
            }


            Console.WriteLine(dough.Calories());
            Console.WriteLine(topping.CaloriesTopping());
        }
    }
}
