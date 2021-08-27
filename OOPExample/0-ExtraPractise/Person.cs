using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_ExtraPractise
{
    class Person
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }

        public string GetFullName()
        {
            string fullName = $"My Full Name is {FirstName} {LasttName}";
            return fullName;
        }
    }
}
