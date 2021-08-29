using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndCollectionInitializer
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public Person()
        {

        }
        public Person( string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
