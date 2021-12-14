using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrep141221
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            var freshness = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int dippingSauce = 0, greenSalad = 0, chocolateCake = 0, Lobster = 0;
            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                var ingridian = ingredients.Peek();
                if (ingridian == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }
                var fresh = freshness.Peek();
                if (ingridian * fresh == 300)
                {
                    chocolateCake++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (ingridian * fresh == 400)
                {
                    Lobster++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (ingridian * fresh == 150)
                {
                    dippingSauce++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (ingridian * fresh == 250)
                {
                    greenSalad++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    ingredients.Enqueue(ingridian + 5);
                }

            }

            if (dippingSauce>0&& chocolateCake > 0 && greenSalad > 0 && Lobster > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($"# Chocolate cake --> {chocolateCake}");
                Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                Console.WriteLine($"# Green salad --> {greenSalad}");
                Console.WriteLine($"# Lobster --> {Lobster}");

            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if(ingredients.Sum()>0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
                if (chocolateCake > 0)
                {
                    Console.WriteLine($"# Chocolate cake --> {chocolateCake}");
                }
                if (dippingSauce > 0)
                {
                    Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                }
                if (greenSalad > 0)
                {
                    Console.WriteLine($"# Green salad --> {greenSalad}");
                }
                if (Lobster > 0)
                {
                    Console.WriteLine($"# Lobster --> {Lobster}");
                }
            }
        }
    }
}
