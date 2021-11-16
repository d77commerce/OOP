using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            Person person = null;
            Product product = null;
            string[] personsInput = Console.ReadLine().Split(";");
            for (int i = 0; i < personsInput.Length; i++)
            {
                string[] infoPerson = personsInput[i].Split("=");
                person = new Person(infoPerson[0], decimal.Parse(infoPerson[1]));

                people.Add(infoPerson[0], person);
            }
            string[] productInput = Console.ReadLine().Split(";");
            for (int J = 0; J < productInput.Length; J++)
            {
                string[] infoProduct = productInput[J].Split("=");
                product = new Product(infoProduct[0], decimal.Parse(infoProduct[1]));
                products.Add(infoProduct[0], product);
            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] act = input.Split();
                string curentName = act[0];
                string curentProduct = act[1];
                 if (people.ContainsKey(curentName)&& products.ContainsKey(curentProduct))
                {
                    people[curentName].Buying(products[curentProduct]);

                }
                input = Console.ReadLine();
            }
            foreach (var peopleZ in people)
            {
                Console.WriteLine(peopleZ.Value.ToString());
            }
        }
    }
}
