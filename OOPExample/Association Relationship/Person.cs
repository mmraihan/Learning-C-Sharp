using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Relationship
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Address PresentAddress { get; set; }


        public string GetFullName()
        {
            string fullname = $"{FirstName + " " + MiddleName + " " + LastName}";
            return fullname;
        }
    }
}
