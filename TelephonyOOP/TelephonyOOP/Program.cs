using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TelephonyOOP
{
  public  class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] web = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < num.Length; i++)
            {
                ICalling call = null;
                if (num[i].Length == 7 && num[i].All(x => char.IsDigit(x)))
                {
                    call = new StationaryPhone();
                    Console.WriteLine(call.Calling(num[i]));
                }
                else if (num[i].Length == 10 && num[i].All(x => char.IsDigit(x)))
                {
                    call = new Smartphone();
                    Console.WriteLine(call.Calling(num[i]));
                }
                else
                {
                    Console.WriteLine($"Invalid number!");
                }

            }

            for (int j = 0; j < web.Length; j++)
            {
                IWeb browse = null;
                if (!Regex.IsMatch(web[j], @"[0-9]"))
                {
                    browse = new Smartphone();
                    Console.WriteLine(browse.Browsing(web[j]));
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }

        }
    }
}
