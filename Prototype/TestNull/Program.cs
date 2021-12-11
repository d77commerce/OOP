using System;

namespace TestNull
{
    class Person
    {
        private int? myVar;
        private int age;
        public int? NomOfKids
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public int Age

        {
            get { return age; }
            set { age = value; }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.NomOfKids = null;
            Console.WriteLine((person.NomOfKids.HasValue) ? "have " : "No have");
            Console.WriteLine(person.NomOfKids ?? 0);
            Person person1 = new Person() { Age = 3 };
            Person person2 = null;
            Console.WriteLine((person1 ==null)? null : person1.Age);
            Console.WriteLine(person1?.Age);
            Console.WriteLine();
            Console.WriteLine((person2 ==null)? null:person2.Age);
            Console.WriteLine(person2?.Age);

        }
    }
}
