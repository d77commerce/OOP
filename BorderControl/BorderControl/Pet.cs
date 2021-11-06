using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : IName , IBirthdates
    {
        public Pet(string name, string birthdates)
        {
            Name = name;
            Birthdates = birthdates;
        }

        public string Name { get; }

        public string Birthdates { get; }
    }
}
