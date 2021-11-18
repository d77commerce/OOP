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

            Dough dough = new Dough(flourType, bakingTechnique, grams);

            Console.WriteLine(dough.Calories());
        }
    }
}
