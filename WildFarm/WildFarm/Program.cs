using System;
using System.Collections.Generic;
using WildFarm.animals;
using WildFarm.food;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IAnimal> animals = new List<IAnimal>();
           
            IFood food = null;
 IAnimal animal = null;

            while (input != "End")
            {
                string[] info = input.Split();
                string typeAnimal = info[0];
                string name = info[1];
                double animalWeight = double.Parse(info[2]);
                string[] foodTypeAndQty = Console.ReadLine().Split();
                string foodType = foodTypeAndQty[0];
                int foodQty = int.Parse(foodTypeAndQty[1]);
                if (foodType == "Vegetable")
                {
                    food = new Vegetable(foodQty);
                }
                else if (foodType == "Fruit")
                {
                    food = new Fruits(foodQty);
                }
                else if (foodType == "Meat")
                {
                    food = new Meat(foodQty);
                }
                else if (foodType == "Seeds")
                {
                    food = new Seeds(foodQty);
                }

                switch (typeAnimal)
                {
                    case "Cat":
                        {
                            animal = new Cat(name, animalWeight, info[3], info[4]);
                            Console.WriteLine(animal.Saund());
                            animal.Eat(food);
                            animals.Add(animal);
                            break;
                        }
                    case "Tiger":
                        {
                            animal = new Tiger(name, animalWeight, info[3], info[4]);
                            Console.WriteLine(animal.Saund());
                            animal.Eat(food);
                            animals.Add(animal);
                            break;

                        }
                    case "Mouse":
                        {
                            animal = new Mouse(name, animalWeight, info[3]);
                            Console.WriteLine(animal.Saund());
                            animal.Eat(food);
                            animals.Add(animal);
                            break;

                        }
                    case "Dog":
                        {
                            animal = new Dog(name, animalWeight, info[3]);
                            Console.WriteLine(animal.Saund());
                            animal.Eat(food);
                            animals.Add(animal);
                            break;
                        }
                    case "Owl":
                        {
                            animal = new Owl(name, animalWeight, double.Parse(info[3]));
                            Console.WriteLine(animal.Saund());
                            animal.Eat(food);
                            animals.Add(animal);
                            break;
                        }
                    case "Hen":
                        {
                            animal = new Hen(name, animalWeight, double.Parse(info[3]));
                            Console.WriteLine(animal.Saund());
                            animal.Eat(food);
                            animals.Add(animal);
                            break;
                        }
                }

                input = Console.ReadLine();
            }
            foreach (var animaLL in animals)
            {
                Console.WriteLine(animaLL.ToString());
            }
        }
    }
}
