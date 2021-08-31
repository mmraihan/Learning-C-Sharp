using System;

namespace BITM_18_ValueRefType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FitrstName = "Md";
            person1.MiddleName = "Mubasshir";
            person1.LastName = "Raihan";

            Person person2 = new Person();
            person2.FitrstName = "Kazi";
            person2.MiddleName = "Bijoy";
            person2.LastName = "Uddin";


            Person person3;
            person3 = person1; // Person 1 Reference nai , kintu object ase.
            person1 = null;

            Person person4 = person3;

            Change(person4);
           
          

            Console.WriteLine(person3.GetFullName()); 
        }

        public static void Change(Person person)
        {
            person.LastName = "Changed";
        }
    }
}
