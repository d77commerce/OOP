using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Citizens : IName, IAge, IId,IBirthdates
    {
        public Citizens(string name, int age, string id,string birthdates)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdates = birthdates;
        }
        public string Birthdates { get; set; }

        public string Name { get; }

        public int Age { get; }

        public string Id { get; }
    }
}
