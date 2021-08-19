using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
  public  class Person
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {
          
            MiddleName = middleName;
          
        }

        public Person(string firstName, string lastName) : this()
        {
            FirstName = firstName;
          
            LastName = lastName;

        }

        public Person()
        {
            Console.WriteLine("Hello default Ctor");
        }

        public string GetFullName()
        {
            string fullname = $"{FirstName + " " + MiddleName + " " + LastName}";
            return fullname;
        }
    }
}
