using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<IId> user = new List<IId>();
            List<IBirthdates> birthdates = new List<IBirthdates>();
            while (input[0] != "End")
            {
                if (input[0] == "Robots")
                {
                    Robots robot = new Robots(input[1], input[2]);
                    user.Add(robot);
                }
                else if (input[0] == "Citizen")
                {
                    Citizens citizen = new Citizens(input[1], int.Parse(input[2]), input[3], input[4]);
                    user.Add(citizen);
                    birthdates.Add(citizen);
                }
                else
                {
                    Pet pet = new Pet(input[1], input[2]);
                    birthdates.Add(pet);
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            string action = Console.ReadLine();
            foreach (var birthday in birthdates)
            {
                string patern = @"\d{2}\/\d{2}\/"+action;

                Regex regex = new Regex(patern);
                if (regex.IsMatch(birthday.Birthdates))
                {
                    Console.WriteLine(birthday.Birthdates);
                }

            }
        }
    }
}
