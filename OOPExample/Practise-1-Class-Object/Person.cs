using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_1_Class_Object
{
    class Person
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public int Age { get; private set; }

        public Person(string firstName, string lastNamem, int age)
        {
            FirstName = firstName;
            LastName = lastNamem;
            Age = age;
        }

        public void GetPersonInformation() 
        {
           

            Console.WriteLine($"Person's Full Name- {FirstName}, {LastName} and {Age}");
        }

        public void GetPersonInformation(string firstName, string lastNamem, int age)
        {
            FirstName = firstName;
            LastName = lastNamem;
            Age = age;

            Console.WriteLine($"Person's Full Name- {FirstName}, {LastName} and {Age}");
        }

    }
}
