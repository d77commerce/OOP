using System;
using System.Collections.Generic;
using System.Text;

namespace TelephonyOOP
{
   public class Smartphone : ICalling , IWeb
    {
        public string Calling(string number)
        {
            return $"Calling... {number}";
        }
        public string Browsing(string input)
        {
            return $"Browsing: {input}!";
        }
       
    }
}
