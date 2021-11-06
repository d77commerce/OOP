using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                var person = new Person(input[0], input[1], int.Parse(input[2]),decimal.Parse(input[3]));
                persons.Add(person);

            }
            var parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(x => x.IncreaseSalary(parcentage));
            persons.ForEach(x => Console.WriteLine(x.ToString()));


        }
    }
}
