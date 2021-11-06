using System;
using System.Collections.Generic;
using System.Text;

namespace TelephonyOOP
{
    public class StationaryPhone : ICalling
    {
        public string Calling(string number)
        {
            return $"Dialing... {number}";
        }

    }
}
